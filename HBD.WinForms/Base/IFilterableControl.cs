using HBD.Data.Comparisons.Base;
using System;

namespace HBD.WinForms.Base
{
    public interface IFilterableControl : IControl
    {
        //public object DataSource { get; set; }

        /// <summary>
        /// List The names of Columns
        /// </summary>
        ColumnItemCollection ColumnItems { get; }

        /// <summary>
        /// Event when number of columns int the list/grid changed.
        /// </summary>
        event EventHandler ColumnNamesChanged;

        void Filter(ICondition filterClause);
    }
}