using System;
using System.ComponentModel;
using System.Data;

namespace HBD.WinForms.DataAdapters
{
    [DefaultValue("DataTable")]
    public interface IDataAdapterControl
    {
        /// <summary>
        ///     The the name of source.
        /// </summary>
        string Text { get; }

        /// <summary>
        ///     The data of source.
        /// </summary>
        DataTable DataTable { get; }

        /// <summary>
        ///     The event when source changes.
        /// </summary>
        event EventHandler TextChanged;
    }
}