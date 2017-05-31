using System;
using System.ComponentModel;
using System.Windows.Forms;
using HBD.WinForms.EventArguments;
using HBD.WinForms.UserControls;

namespace HBD.WinForms.Base
{
    internal interface IDoubleDataGridView : ISupportInitialize
    {
        DoubleDataSource<object> DataSource { get; set; }
        DataGridViewExtended LeftDataGrid { get; }
        DataGridViewExtended RightDataGrid { get; }
        event DataGridViewCellCancelEventHandler CellBeginEdit;

        event DataGridViewCellEventHandler CellEndEdit;

        event DataGridViewCellEventHandler CellErrorTextChanged;

        event DataGridViewCellErrorTextNeededEventHandler CellErrorTextNeeded;

        event DataGridViewCellFormattingEventHandler CellFormatting;

        event DataGridViewCellEventHandler CellLeave;

        event DataGridViewCellMouseEventHandler CellMouseClick;

        event DataGridViewCellMouseEventHandler CellMouseDoubleClick;

        event DataGridViewCellMouseEventHandler CellMouseDown;

        event DataGridViewCellEventHandler CellMouseEnter;

        event DataGridViewCellEventHandler CellMouseLeave;

        event DataGridViewCellMouseEventHandler CellMouseMove;

        event DataGridViewCellMouseEventHandler CellMouseUp;

        event DataGridViewCellPaintingEventHandler CellPainting;

        event DataGridViewCellParsingEventHandler CellParsing;

        event DataGridViewCellStateChangedEventHandler CellStateChanged;

        event DataGridViewCellEventHandler CellValidated;

        event DataGridViewCellValidatingEventHandler CellValidating;

        event DataGridViewCellEventHandler CellValueChanged;

        void ClearSelection();

        event DataGridViewColumnEventHandler ColumnAdded;

        event DataGridViewColumnEventHandler ColumnRemoved;

        event DataGridViewBindingCompleteEventHandler DataBindingComplete;

        void HideAllColumns();

        void HideAllRows();

        void HidEmptyFormatRows();

        void Refresh();

        void ResumeBinding();

        event DataGridViewRowPostPaintEventHandler RowPostPaint;

        event DataGridViewRowPrePaintEventHandler RowPrePaint;

        event DataGridViewRowsAddedEventHandler RowsAdded;

        event DataGridViewRowsRemovedEventHandler RowsRemoved;

        event EventHandler<DataGridSelectionChangedEventArgs> SelectionChanged;

        void ShowAllColumns();

        void ShowAllRows();

        //void SortColumnHeaders();
        //void SortColumnHeaders(HBD.Framework.Data.Comparison.FieldComparison excludeColumn);
        //void SortColumnHeadersByIndexOfFields(HBD.Framework.Data.Comparison.FieldComparisonCollection fields);
        //void SortRowsBy(HBD.Framework.Data.Comparison.FieldComparison field, System.ComponentModel.ListSortDirection direction);
        void SuspendBinding();
    }
}