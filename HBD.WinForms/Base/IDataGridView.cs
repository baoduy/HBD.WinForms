using System;
using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    public interface IDataGridView : ISearchable, IFilterableControl
    {
        DataGridViewColumnCollection Columns { get; }
        DataGridViewCell CurrentCell { get; set; }

        bool IsEditing { get; }
        bool ReadOnly { get; set; }
        DataGridViewRowCollection Rows { get; }
        DataGridViewSelectedCellCollection SelectedCells { get; }
        DataGridViewSelectedColumnCollection SelectedColumns { get; }
        DataGridViewSelectedRowCollection SelectedRows { get; }
        DataGridViewSelectionMode SelectionMode { get; set; }
        object DataSource { get; set; }
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

        event DataGridViewColumnEventHandler ColumnAdded;

        event DataGridViewColumnEventHandler ColumnRemoved;

        event DataGridViewBindingCompleteEventHandler DataBindingComplete;

        event EventHandler DataSourceChanged;

        bool EndEdit();

        bool EndEdit(DataGridViewDataErrorContexts contexts);

        event DataGridViewRowPostPaintEventHandler RowPostPaint;

        event DataGridViewRowPrePaintEventHandler RowPrePaint;

        event DataGridViewRowsAddedEventHandler RowsAdded;

        event DataGridViewRowsRemovedEventHandler RowsRemoved;
    }
}