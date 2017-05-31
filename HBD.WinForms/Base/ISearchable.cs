using System;
using HBD.WinForms.EventArguments;
using HBD.WinForms.Utilities;

namespace HBD.WinForms.Base
{
    public interface ISearchable : IControl
    {
        ISearchManager SearchManager { get; }
        int ItemCount { get; }

        bool Enabled { get; set; }

        /// <summary>
        ///     Event when number of items in the List/Gird changed
        /// </summary>
        event EventHandler ItemsChanged;

        void Search(string keyword);

        event EventHandler<SearchlEventArgs> SearchStatusChanged;
    }
}