using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using HBD.Framework.Core;

namespace HBD.WinForms.Utilities
{
    public abstract class SearchManagerBase<TControl, TItem> : ISearchManager
        where TControl : Control
        where TItem : class
    {
        protected readonly object Locker = new object();

        private volatile SearchStatus _status = SearchStatus.None;
        protected volatile int CurrentIndex;
        protected volatile bool StopSearching;

        protected SearchManagerBase(TControl control)
        {
            Control = control;
            Result = new List<TItem>();
            Status = SearchStatus.None;
            CurrentIndex = -1;
            StopSearching = false;
        }

        public TControl Control { get; protected set; }

        public TItem CurrentItem
        {
            get
            {
                EnsureSearched();
                if (CurrentIndex == -1)
                    return null;
                if (Result.Count == 0)
                    return null;
                return Result[CurrentIndex];
            }
        }

        protected IList<TItem> Result { get; set; }

        //protected Thread CurrentThread { get; set; }
        protected Thread CurrentThread { get; set; }

        public abstract object CurrentItemValue { get; }
        public string Keyword { get; set; }

        public SearchStatus Status
        {
            get { return _status; }
            protected set
            {
                if (_status == value) return;
                _status = value;
                OnStatusChanged(EventArgs.Empty);
            }
        }

        public int Total => Result.Count;

        public event EventHandler StatusChanged;

        public virtual bool Next()
        {
            EnsureSearched();

            if (Result.Count == 0)
                return false;

            if (CurrentIndex >= Result.Count - 1) return false;

            var item = Result[++CurrentIndex];
            //Find next visible item
            while (!SetFocusToItem(item) && (CurrentIndex < Result.Count - 1))
            {
                if (CurrentIndex == Result.Count)
                    return false;
                item = Result[++CurrentIndex];
            }

            return true;
        }

        public virtual bool Previous()
        {
            EnsureSearched();

            if (Result.Count == 0)
                return false;

            if (CurrentIndex <= 0) return false;

            var item = Result[--CurrentIndex];
            //Find next visible item
            while (!SetFocusToItem(item) && (CurrentIndex < Result.Count - 1))
            {
                if (CurrentIndex == -1)
                    return false;
                item = Result[--CurrentIndex];
            }
            return true;
        }

        /// <summary>
        ///     Clear result and reset the Search
        /// </summary>
        public virtual void Reset()
        {
            ForceStopCurrentThread();
            Status = SearchStatus.None;
            StopSearching = false;
            ClearResult();
        }

        public virtual void Search()
        {
            Guard.ArgumentIsNotNull(Control, "Searchable Control");
            Reset();
            Status = SearchStatus.Started;

            //If keyword is empty that mean just clear and reset the Search result.
            if (string.IsNullOrEmpty(Keyword))
            {
                Status = SearchStatus.Completed;
                return;
            }
            DoSearch();
        }

        public virtual void Search(string keyword)
        {
            Keyword = keyword;
            Search();
        }

        public virtual void Stop() => StopSearching = true;

        public void SetCurrentIndex(object item) => SetCurrentIndex(item as TItem);

        public virtual void SetCurrentIndex(TItem item) => CurrentIndex = Result.IndexOf(item);

        protected virtual void AddResult(TItem item)
        {
            Result.Add(item);
            Status = SearchStatus.ResultFound;
        }

        protected abstract void ClearHighLightItem(TItem item);

        /// <summary>
        ///     Implement the search method when search is done call 'OnSearchCompleted'
        /// </summary>
        protected abstract void DoSearch();

        /// <summary>
        ///     Highlight item with special color
        /// </summary>
        /// <param name="item"></param>
        protected abstract void HighLightItem(TItem item);

        protected virtual void OnStatusChanged(EventArgs e)
        {
            if (Control.InvokeRequired)
            {
                Control.Invoke((Action<EventArgs>) OnStatusChanged, e);
                return;
            }

            if (Status == SearchStatus.Completed)
                HighLightResult();
            if (StatusChanged != null)
                StatusChanged(this, e);
        }

        /// <summary>
        ///     Set current item or focus to this item on the UI layer.
        /// </summary>
        /// <param name="item">The item will be focused</param>
        /// <returns>The indicate whether item can be focused</returns>
        protected abstract bool SetFocusToItem(TItem item);

        /// <summary>
        ///     Clear search results.
        /// </summary>
        private void ClearResult()
        {
            if (Result.Count > 0)
            {
                foreach (var item in Result)
                    ClearHighLightItem(item);
                Result.Clear();
                CurrentIndex = -1;
            }
        }

        private void EnsureSearched()
        {
            if (Status == SearchStatus.None)
                throw new Exception("Please call search method first.");
        }

        private void ForceStopCurrentThread()
        {
            if (CurrentThread == null) return;
            //Force to stop the old thread
            try
            {
                CurrentThread.Abort();
            }
            finally
            {
                CurrentThread = null;
            }
        }

        /// <summary>
        ///     Clear highlighted results.
        /// </summary>
        private void HighLightResult()
        {
            foreach (var cell in Result)
                HighLightItem(cell);
        }
    }
}