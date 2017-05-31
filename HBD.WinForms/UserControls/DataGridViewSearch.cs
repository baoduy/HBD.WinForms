using HBD.WinForms.Base;
using HBD.WinForms.EventArguments;
using HBD.WinForms.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    public partial class DataGridViewSearch : UserControl
    {
        private ISearchable _searchableControl;
        private DisabledWithCursorWaitor<DataGridViewSearch> waitor;

        public DataGridViewSearch()
        {
            InitializeComponent();
            Enabled = false;
            MinimumSize = new Size(200, 20);
        }

        [DefaultValue("(none)")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ISearchable SearchableControl
        {
            get { return _searchableControl; }
            set
            {
                if (_searchableControl == value) return;

                //Remove Event handler for existing control
                if (_searchableControl != null)
                {
                    SearchableControl.SearchStatusChanged -= SearchableControl_SearchStatusChanged;
                    _searchableControl.ItemsChanged -= SearchableControl_ItemsChanged;
                }

                //Set and add event handler for new control.
                _searchableControl = value;
                SearchableControl.SearchStatusChanged += SearchableControl_SearchStatusChanged;
                _searchableControl.ItemsChanged += SearchableControl_ItemsChanged;
            }
        }

        public void Search()
        {
            if (SearchableControl == null) return;

            if (SearchableControl.SearchManager.Status == SearchStatus.None)
            {
                waitor = this.DisableWithWaitCursor();
                SearchableControl.Search(searchTextBox.Text);
            }
            else
            {
                bt_Next.Enabled = SearchableControl.SearchManager.Next();
                bt_Back.Visible = true;
                bt_Back.Enabled = true;
            }
        }

        public void Stop() => SearchableControl?.SearchManager.Stop();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Height = searchTextBox.Height + searchTextBox.Margin.All * 2;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            if (SearchableControl.SearchManager.Status != SearchStatus.None)
                bt_Back.Enabled = SearchableControl.SearchManager.Previous();
            bt_Next.Enabled = _searchableControl.SearchManager.Total > 0;
        }

        private void bt_Search_Click(object sender, EventArgs e) => Search();

        private void SearchableControl_ItemsChanged(object sender, EventArgs e)
            => Enabled = SearchableControl.ItemCount > 0;

        private void SearchableControl_SearchStatusChanged(object sender, SearchlEventArgs e)
        {
            switch (e.SearchManager.Status)
            {
                case SearchStatus.None:
                    bt_Back.Visible = false;
                    break;

                case SearchStatus.Started:
                    {
                        searchTextBox.Enabled = false;
                    }
                    break;

                case SearchStatus.ResultFound:
                    waitor?.Dispose();
                    break;

                case SearchStatus.Completed:
                    {
                        waitor?.Dispose();
                        searchTextBox.Enabled = true;
                    }
                    break;
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0)
                SearchableControl?.SearchManager.Search();
            else SearchableControl?.SearchManager.Stop();
        }
    }
}