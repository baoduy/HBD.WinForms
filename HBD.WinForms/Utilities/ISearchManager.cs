using System;

namespace HBD.WinForms.Utilities
{
    public interface ISearchManager
    {
        object CurrentItemValue { get; }
        string Keyword { get; set; }

        SearchStatus Status { get; }
        int Total { get; }

        bool Next();

        bool Previous();

        void Reset();

        void Search();

        void Search(string keyWord);

        void SetCurrentIndex(object item);

        event EventHandler StatusChanged;

        void Stop();
    }

    public enum SearchStatus
    {
        None,
        Started,
        ResultFound,
        Completed
    }
}