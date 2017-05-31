using System;
using HBD.WinForms.Utilities;

namespace HBD.WinForms.EventArguments
{
    public class SearchlEventArgs : EventArgs
    {
        public SearchlEventArgs(ISearchManager searchManager)
        {
            SearchManager = searchManager;
        }

        public ISearchManager SearchManager { get; set; }
    }
}