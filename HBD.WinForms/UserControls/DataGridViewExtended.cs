using HBD.Data.Comparisons;
using HBD.Data.Comparisons.Base;
using HBD.Framework.Core;
using HBD.WinForms.Base;
using HBD.WinForms.EventArguments;
using HBD.WinForms.Utilities;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(DataGridView))]
    public class DataGridViewExtended : DataGridView, IDataGridView
    {
        private bool _isColumnHeaderClicked;

        private bool _isRowHeaderClicked;

        public DataGridViewExtended()
        {
            ShowRowNumbers = true;
            AutoSwitchSelectionMode = true;
        }

        #region Properties

        [DefaultValue(true)]
        public bool ShowRowNumbers { get; set; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(DataGridViewSelectionMode.CellSelect)]
        public new virtual DataGridViewSelectionMode SelectionMode
        {
            get { return base.SelectionMode; }
            set
            {
                if (base.SelectionMode == value) return;
                if ((value == DataGridViewSelectionMode.FullColumnSelect) &&
                    (ColumnSortMode == DataGridViewColumnSortMode.Automatic))
                    return;

                base.SelectionMode = value;
                OnSelectionModeChanged(EventArgs.Empty);
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool AutoSwitchSelectionMode { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(false)]
        public bool IsEditing { get; protected set; }

        private DataGridViewColumnSortMode _columnSortMode = DataGridViewColumnSortMode.Automatic;

        /// <summary>
        /// Enable the AllowUserToOrderColumns and to enable the ColumnSortMode.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(DataGridViewColumnSortMode.Automatic)]
        public virtual DataGridViewColumnSortMode ColumnSortMode
        {
            get { return !AllowUserToOrderColumns ? DataGridViewColumnSortMode.NotSortable : _columnSortMode; }
            set { _columnSortMode = value; }
        }

        public event EventHandler SelectionModeChanged;

        protected virtual void OnSelectionModeChanged(EventArgs e) => SelectionModeChanged?.Invoke(this, e);

        #endregion Properties

        #region Searchable

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ItemCount => RowCount;

        private ISearchManager _searchManager;

        [Browsable(false)]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ISearchManager SearchManager
        {
            get
            {
                if (_searchManager == null)
                {
                    _searchManager = new DataGridViewSearchManager(this);
                    _searchManager.StatusChanged += _searchManager_StatusChanged;
                }
                return _searchManager;
            }
        }

        private void _searchManager_StatusChanged(object sender, EventArgs e)
            => OnSearchStatusChanged(new SearchlEventArgs(SearchManager));

        /// <summary>
        /// Indication whatever row added or removed
        /// </summary>
        public event EventHandler ItemsChanged;

        protected virtual void OnItemsChanged(EventArgs e) => ItemsChanged?.Invoke(this, e);

        public event EventHandler<SearchlEventArgs> SearchStatusChanged;

        public virtual void OnSearchStatusChanged(SearchlEventArgs e) => SearchStatusChanged?.Invoke(this, e);

        public virtual void Search(string keyword) => SearchManager.Search(keyword);

        #endregion Searchable

        #region Public methods

        public new virtual void ClearSelection()
        {
            CurrentCell = null;
            base.ClearSelection();
        }

        public virtual void HideAllRows()
        {
            ClearSelection();
            foreach (DataGridViewRow row in Rows)
                row.Visible = false;
        }

        public virtual void HideSelectedRows()
        {
            var rows = SelectedRows;
            ClearSelection();

            foreach (DataGridViewRow r in rows)
                r.Visible = false;
        }

        public virtual void HideEmptyFormatRows()
        {
            ClearSelection();

            foreach (DataGridViewRow row in Rows)
            {
                if (row.DefaultCellStyle.BackColor != Color.Empty) continue;
                row.Visible =
                    Columns.Cast<DataGridViewColumn>().Any(col => row.Cells[col.Name].Style.BackColor != Color.Empty);
            }
        }

        public virtual void ShowAllRows()
        {
            foreach (var row in Rows.Cast<DataGridViewRow>().Where(row => !row.Visible))
                row.Visible = true;
        }

        public virtual int GetDisplayRowIndex(int rowIndex)
        {
            var i = -1;
            foreach (DataGridViewRow row in Rows)
            {
                if (row.Visible)
                    i++;
                if (row.Index == rowIndex)
                    return i;
            }
            return -1;
        }

        public virtual int GetDisplayColumnIndex(int columnIndex) => Columns[columnIndex].DisplayIndex;

        public virtual DataGridViewRow GetDisplayRow(int displayRowIndex)
        {
            var i = 0;
            foreach (var row in Rows.Cast<DataGridViewRow>().Where(row => row.Visible))
            {
                if (i == displayRowIndex)
                    return row;
                i++;
            }

            return null;
        }

        public virtual DataGridViewColumn GetDisplayColumn(int displayColumnIndex)
            =>
            Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(col => col.Visible && (col.DisplayIndex == displayColumnIndex));

        public virtual DataGridViewRow GetDisplayRowByIndex(int rowIndex)
        {
            var disIndex = GetDisplayRowIndex(rowIndex);
            if (disIndex >= 0)
                return GetDisplayRow(disIndex);
            return null;
        }

        public virtual DataGridViewColumn GetDisplayColumnByIndex(int columnIndex)
        {
            var disIndex = GetDisplayColumnIndex(columnIndex);
            if (disIndex >= 0)
                return GetDisplayColumn(disIndex);
            return null;
        }

        public virtual DataGridViewCell GetDisplayCell(int displayRowIndex, int displayColumnIndex)
        {
            var row = GetDisplayRow(displayRowIndex);
            if (row == null)
                return null;

            var col = GetDisplayColumn(displayColumnIndex);
            return col == null ? null : row.Cells[col.Name];
        }

        public virtual DataGridViewCell GetDisplayCellByIndex(int rowIndex, int columnIndex)
        {
            var disRowIndex = GetDisplayRowIndex(rowIndex);
            if (disRowIndex < 0)
                return null;

            var disColIndex = GetDisplayColumnIndex(columnIndex);
            if (disColIndex < 0)
                return null;

            return GetDisplayCell(disRowIndex, disColIndex);
        }

        public virtual void SyncSelectedTo(DataGridViewExtended syncGrid)
        {
            Guard.ArgumentIsNotNull(syncGrid, "syncGrid");

            var originalOfAutoSwitchSelectionMode = syncGrid.AutoSwitchSelectionMode;
            syncGrid.AutoSwitchSelectionMode = false;
            syncGrid.SelectionMode = SelectionMode;
            syncGrid.ClearSelection();

            switch (SelectionMode)
            {
                case DataGridViewSelectionMode.CellSelect:
                    {
                        //Cell Selection Mode
                        for (var i = 0; i < SelectedCells.Count; i++)
                        {
                            var cell = SelectedCells[i];

                            var disRowIndex = GetDisplayRowIndex(cell.RowIndex);
                            var disColIndex = GetDisplayColumnIndex(cell.ColumnIndex);

                            var syncCell = syncGrid.GetDisplayCell(disRowIndex, disColIndex);
                            if (syncCell != null)
                                syncCell.Selected = true;
                        }
                    }
                    break;

                case DataGridViewSelectionMode.FullRowSelect:
                    {
                        foreach (DataGridViewRow row in SelectedRows)
                        {
                            var displayRowIndex = GetDisplayRowIndex(row.Index);
                            var syncRow = syncGrid.GetDisplayRow(displayRowIndex);
                            if (syncRow != null)
                                syncRow.Selected = true;
                        }
                    }
                    break;

                case DataGridViewSelectionMode.FullColumnSelect:
                    {
                        foreach (DataGridViewColumn col in SelectedColumns)
                        {
                            var displayIndex = GetDisplayColumnIndex(col.Index);
                            var syncCol = syncGrid.GetDisplayColumn(displayIndex);
                            if (syncCol != null)
                                syncCol.Selected = true;
                        }
                    }
                    break;
                    //case DataGridViewSelectionMode.RowHeaderSelect:
                    //    break;
                    //case DataGridViewSelectionMode.ColumnHeaderSelect:
                    //    break;
                    //default:
                    //    throw new ArgumentOutOfRangeException();
            }

            syncGrid.AutoSwitchSelectionMode = originalOfAutoSwitchSelectionMode;
        }

        public virtual void SyncScrolledPositionTo(DataGridViewExtended syncGrid)
        {
            Guard.ArgumentIsNotNull(syncGrid, "syncGrid");

            var disRowIndex = GetDisplayRowIndex(FirstDisplayedScrollingRowIndex);
            var disColIndex = GetDisplayColumnIndex(FirstDisplayedScrollingColumnIndex);

            var row = syncGrid.GetDisplayRowByIndex(disRowIndex);
            var col = syncGrid.GetDisplayColumn(disColIndex);

            if (row != null)
                syncGrid.FirstDisplayedScrollingRowIndex = row.Index;

            if (col != null)
                syncGrid.FirstDisplayedScrollingColumnIndex = col.Index;
        }

        /// <summary>
        /// Delete Selected Rows.
        /// </summary>
        public void DeleteSelectedRows()
        {
            var rowIndexes =
                SelectedCells.Cast<DataGridViewCell>().Select(c => c.RowIndex).ToArray();
            ClearSelection();
            EndEdit();

            foreach (var index in rowIndexes)
            {
                if (Rows[index].IsNewRow) continue;
                Rows.RemoveAt(index);
            }
        }

        /// <summary>
        /// Delete Selected Columns.
        /// </summary>
        public void DeleteSelectedColumns()
        {
            var colIndexes =
                SelectedCells.Cast<DataGridViewCell>().Select(c => c.ColumnIndex).ToArray();
            ClearSelection();
            EndEdit();

            foreach (var index in colIndexes)
                Columns.RemoveAt(index);
        }

        #endregion Public methods

        #region Override Events

        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);

            e.Column.SortMode = ColumnSortMode;

            _columnItems?.Clear();
            OnColumnNamesChanged(EventArgs.Empty);
        }

        protected override void OnColumnRemoved(DataGridViewColumnEventArgs e)
        {
            base.OnColumnRemoved(e);
            ColumnItems.Remove(e.Column.Name);
            OnColumnNamesChanged(EventArgs.Empty);
        }

        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            if (ShowRowNumbers && RowHeadersVisible)
            {
                //this method overrides the DataGridView's RowPostPaint event
                //in order to automatically draw numbers on the row header cells
                //and to automatically adjust the width of the column containing
                //the row header cells so that it can accommodate the new row
                //numbers,

                //store a string representation of the row number in 'strRowNumber'
                var strRowNumber = (e.RowIndex + 1).ToString();

                //appearance. For example, if there are ten rows in the grid,
                //row seven will be numbered as "07" instead of "7". Similarly, if
                //there are 100 rows in the grid, row seven will be numbered as "007".
                var strLengh = strRowNumber.Length;
                var rowCountLength = RowCount.ToString().Length;
                if (strLengh < rowCountLength)
                    strRowNumber = new string('0', rowCountLength - strLengh) + strRowNumber;

                //determine the display size of the row number string using
                //the DataGridView's current font.
                var size = e.Graphics.MeasureString(strRowNumber, Font);

                //adjust the width of the column that contains the row header cells
                //if necessary
                if (RowHeadersWidth < (int)(size.Width + 20)) RowHeadersWidth = (int)(size.Width + 20);

                //this brush will be used to draw the row number string on the
                //row header cell using the system's current ControlText color
                var b = SystemBrushes.ControlText;

                //draw the row number string on the current row header cell using
                //the brush defined above and the DataGridView's default font
                e.Graphics.DrawString(strRowNumber, Font, b, e.RowBounds.Location.X + 15,
                    e.RowBounds.Location.Y + (e.RowBounds.Height - size.Height) / 2);
            }

            base.OnRowPostPaint(e);
        }

        protected override void OnRowHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (AutoSwitchSelectionMode && !AllowUserToOrderColumns)
            {
                _isRowHeaderClicked = true;
                SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (e.RowIndex >= 0)
                    Rows[e.RowIndex].Selected = true;
            }
            base.OnRowHeaderMouseClick(e);
        }

        protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (AutoSwitchSelectionMode)
            {
                _isColumnHeaderClicked = true;
                SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
                if (e.ColumnIndex >= 0)
                    Columns[e.ColumnIndex].Selected = true;
            }
            base.OnColumnHeaderMouseClick(e);
        }

        protected override void OnCellMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (AutoSwitchSelectionMode)
                if (!_isRowHeaderClicked && !_isColumnHeaderClicked)
                {
                    SelectionMode = DataGridViewSelectionMode.CellSelect;
                    if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
                        Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }

            base.OnCellMouseClick(e);

            _isRowHeaderClicked = false;
            _isColumnHeaderClicked = false;

            if (SearchManager.Status == SearchStatus.Completed)
                SearchManager.SetCurrentIndex(CurrentCell);
        }

        protected override void OnCellBeginEdit(DataGridViewCellCancelEventArgs e)
        {
            base.OnCellBeginEdit(e);
            IsEditing = true;
        }

        protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
        {
            base.OnCellEndEdit(e);
            IsEditing = false;
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            SearchManager.Reset();
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            OnItemsChanged(e);
        }

        protected override void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e)
        {
            base.OnRowsRemoved(e);
            OnItemsChanged(e);
        }

        #endregion Override Events

        #region IFilterable

        private ColumnItemCollection _columnItems;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ColumnItemCollection ColumnItems
        {
            get
            {
                if (_columnItems == null)
                    _columnItems = new ColumnItemCollection();
                if ((_columnItems.Count == 0) && (ColumnCount > 0))
                    foreach (DataGridViewColumn col in Columns)
                        _columnItems.Add(col.Name, col.ValueType);
                return _columnItems;
            }
        }

        public event EventHandler ColumnNamesChanged;

        protected virtual void OnColumnNamesChanged(EventArgs e) => ColumnNamesChanged?.Invoke(this, e);

        public void Filter(ICondition filterClause)
        {
            if (DataSource != null)
            {
                var filterString = new DataTableExpressionRender().BuildCondition(filterClause);
                if (DataSource is DataTable)
                    (DataSource as DataTable).DefaultView.RowFilter = filterString;
                else if (DataSource is BindingSource)
                    (DataSource as BindingSource).Filter = filterString;
            }
            else new DataGridViewConditionValidation(this).Validate(filterClause);
        }

        #endregion IFilterable
    }
}