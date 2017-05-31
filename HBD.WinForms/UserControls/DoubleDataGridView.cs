using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HBD.WinForms.Base;
using HBD.WinForms.EventArguments;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(DataGridView))]
    public partial class DoubleDataGridView : DoubleDataSourceControlBase, IDoubleDataGridView
    {
        public DoubleDataGridView()
        {
            InitializeComponent();
        }

        [DefaultValue(true)]
        public bool EnableHeadersVisualStyles
        {
            get { return LeftDataGrid.EnableHeadersVisualStyles; }
            set
            {
                LeftDataGrid.EnableHeadersVisualStyles = value;
                RightDataGrid.EnableHeadersVisualStyles = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewExtended SelectedGrid => LeftDataGrid.Focused ? LeftDataGrid : RightDataGrid;

        public string LeftTitle
        {
            get { return leftLabel.Text; }
            set { leftLabel.Text = value; }
        }

        public string RightTitle
        {
            get { return rightLabel.Text; }
            set { rightLabel.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewExtended LeftDataGrid { get; private set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridViewExtended RightDataGrid { get; private set; }

        protected override void OnDataSourceChanged(PropertyChangedEventArgs e)
        {
            base.OnDataSourceChanged(e);

            if ((LeftDataGrid != null) && (e.PropertyName == nameof(DataSource.LeftDataSource)))
                LeftDataGrid.DataSource = DataSource.LeftDataSource;
            if ((RightDataGrid != null) && (e.PropertyName == nameof(DataSource.RightDataSource)))
                RightDataGrid.DataSource = DataSource.RightDataSource;
        }

        private void dataGrid_Scroll(object sender, ScrollEventArgs e)
        {
            if (!LeftDataGrid.Focused && !RightDataGrid.Focused)
                ((Control) sender).Focus();

            if (sender == LeftDataGrid)
            {
                if (LeftDataGrid.Focused)
                    LeftDataGrid.SyncScrolledPositionTo(RightDataGrid);
            }
            else if (RightDataGrid.Focused)
                RightDataGrid.SyncScrolledPositionTo(LeftDataGrid);
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (sender == LeftDataGrid)
            {
                if (LeftDataGrid.Focused)
                    LeftDataGrid.SyncSelectedTo(RightDataGrid);
            }
            else if (RightDataGrid.Focused)
                RightDataGrid.SyncSelectedTo(LeftDataGrid);

            OnSelectionChanged(new DataGridSelectionChangedEventArgs(sender as DataGridView));
        }

        private void dataGrid_SelectionModeChanged(object sender, EventArgs e)
        {
            if ((sender == LeftDataGrid) && LeftDataGrid.Focused)
                RightDataGrid.SelectionMode = LeftDataGrid.SelectionMode;
            else if (RightDataGrid.Focused)
                LeftDataGrid.SelectionMode = RightDataGrid.SelectionMode;
        }

        #region Public Methods

        public void ClearSelection()
        {
            LeftDataGrid.ClearSelection();
            RightDataGrid.ClearSelection();
        }

        public void ShowAllColumns()
        {
            LeftDataGrid.ShowAllColumns();
            RightDataGrid.ShowAllColumns();
        }

        public void HideAllColumns()
        {
            LeftDataGrid.HideAllColumns();
            RightDataGrid.HideAllColumns();
        }

        public void ShowAllRows()
        {
            ClearSelection();
            for (var i = 0; i < LeftDataGrid.RowCount; i++)
            {
                LeftDataGrid.Rows[i].Visible = true;
                RightDataGrid.Rows[i].Visible = true;
            }
        }

        public void BeginInit()
        {
            ((ISupportInitialize) LeftDataGrid).BeginInit();
            ((ISupportInitialize) RightDataGrid).BeginInit();
        }

        public void EndInit()
        {
            ((ISupportInitialize) LeftDataGrid).EndInit();
            ((ISupportInitialize) RightDataGrid).EndInit();
        }

        public void SuspendBinding()
        {
            ((CurrencyManager) BindingContext[LeftDataGrid.DataSource]).SuspendBinding();
            ((CurrencyManager) BindingContext[RightDataGrid.DataSource]).SuspendBinding();
        }

        public void ResumeBinding()
        {
            ((CurrencyManager) BindingContext[LeftDataGrid.DataSource]).ResumeBinding();
            ((CurrencyManager) BindingContext[RightDataGrid.DataSource]).ResumeBinding();
        }

        public void HideAllRows()
        {
            LeftDataGrid.HideAllRows();
            RightDataGrid.HideAllRows();
        }

        public void HidEmptyFormatRows()
        {
            LeftDataGrid.HideEmptyFormatRows();
            RightDataGrid.HideEmptyFormatRows();
        }

        #endregion Public Methods

        #region Events

        public event EventHandler<DataGridSelectionChangedEventArgs> SelectionChanged;

        protected virtual void OnSelectionChanged(DataGridSelectionChangedEventArgs e)
            => SelectionChanged?.Invoke(this, e);

        public event DataGridViewCellCancelEventHandler CellBeginEdit;

        protected virtual void OnCellBeginEdit(object dataGridView, DataGridViewCellCancelEventArgs e)
            => CellBeginEdit?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellEndEdit;

        protected virtual void OnCellEndEdit(object dataGridView, DataGridViewCellEventArgs e)
            => CellEndEdit?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellErrorTextChanged;

        protected virtual void OnCellErrorTextChanged(object dataGridView, DataGridViewCellEventArgs e)
            => CellErrorTextChanged?.Invoke(dataGridView, e);

        public event DataGridViewCellErrorTextNeededEventHandler CellErrorTextNeeded;

        protected virtual void OnCellErrorTextNeeded(object dataGridView, DataGridViewCellErrorTextNeededEventArgs e)
            => CellErrorTextNeeded?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellLeave;

        protected virtual void OnCellLeave(object dataGridView, DataGridViewCellEventArgs e)
            => CellLeave?.Invoke(dataGridView, e);

        public event DataGridViewCellFormattingEventHandler CellFormatting;

        protected virtual void OnCellFormatting(object dataGridView, DataGridViewCellFormattingEventArgs e)
            => CellFormatting?.Invoke(dataGridView, e);

        public event DataGridViewCellMouseEventHandler CellMouseClick;

        protected virtual void OnCellMouseClick(object dataGridView, DataGridViewCellMouseEventArgs e)
            => CellMouseClick?.Invoke(dataGridView, e);

        public event DataGridViewCellMouseEventHandler CellMouseDoubleClick;

        protected virtual void OnCellMouseDoubleClick(object dataGridView, DataGridViewCellMouseEventArgs e)
            => CellMouseDoubleClick?.Invoke(dataGridView, e);

        public event DataGridViewCellMouseEventHandler CellMouseDown;

        protected virtual void OnCellMouseDown(object dataGridView, DataGridViewCellMouseEventArgs e)
            => CellMouseDown?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellMouseEnter;

        protected virtual void OnCellMouseEnter(object dataGridView, DataGridViewCellEventArgs e)
            => CellMouseEnter?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellMouseLeave;

        protected virtual void OnCellMouseLeave(object dataGridView, DataGridViewCellEventArgs e)
            => CellMouseLeave?.Invoke(dataGridView, e);

        public event DataGridViewCellMouseEventHandler CellMouseMove;

        protected virtual void OnCellMouseMove(object dataGridView, DataGridViewCellMouseEventArgs e)
            => CellMouseMove?.Invoke(dataGridView, e);

        public event DataGridViewCellMouseEventHandler CellMouseUp;

        protected virtual void OnCellMouseUp(object dataGridView, DataGridViewCellMouseEventArgs e)
            => CellMouseUp?.Invoke(dataGridView, e);

        public event DataGridViewCellPaintingEventHandler CellPainting;

        protected virtual void OnCellPainting(object dataGridView, DataGridViewCellPaintingEventArgs e)
            => CellPainting?.Invoke(dataGridView, e);

        public event DataGridViewCellParsingEventHandler CellParsing;

        protected virtual void OnCellParsing(object dataGridView, DataGridViewCellParsingEventArgs e)
            => CellParsing?.Invoke(dataGridView, e);

        public event DataGridViewCellStateChangedEventHandler CellStateChanged;

        protected virtual void OnCellStateChanged(object dataGridView, DataGridViewCellStateChangedEventArgs e)
            => CellStateChanged?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellValidated;

        protected virtual void OnCellValidated(object dataGridView, DataGridViewCellEventArgs e)
            => CellValidated?.Invoke(dataGridView, e);

        public event DataGridViewCellValidatingEventHandler CellValidating;

        protected virtual void OnCellValidating(object dataGridView, DataGridViewCellValidatingEventArgs e)
            => CellValidating?.Invoke(dataGridView, e);

        public event DataGridViewCellEventHandler CellValueChanged;

        protected virtual void OnCellValueChanged(object dataGridView, DataGridViewCellEventArgs e)
            => CellValueChanged?.Invoke(dataGridView, e);

        public event DataGridViewBindingCompleteEventHandler DataBindingComplete;

        protected virtual void OnDataBindingComplete(object dataGridView, DataGridViewBindingCompleteEventArgs e)
            => DataBindingComplete?.Invoke(dataGridView, e);

        public event DataGridViewRowsAddedEventHandler RowsAdded;

        protected virtual void OnRowsAdded(object dataGridView, DataGridViewRowsAddedEventArgs e)
            => RowsAdded?.Invoke(dataGridView, e);

        public event DataGridViewRowsRemovedEventHandler RowsRemoved;

        protected virtual void OnRowsRemoved(object dataGridView, DataGridViewRowsRemovedEventArgs e)
            => RowsRemoved?.Invoke(dataGridView, e);

        public event DataGridViewRowPostPaintEventHandler RowPostPaint;

        protected virtual void OnRowPostPaint(object dataGridView, DataGridViewRowPostPaintEventArgs e)
            => RowPostPaint?.Invoke(dataGridView, e);

        public event DataGridViewRowPrePaintEventHandler RowPrePaint;

        protected virtual void OnRowPrePaint(object dataGridView, DataGridViewRowPrePaintEventArgs e)
            => RowPrePaint?.Invoke(dataGridView, e);

        public event DataGridViewColumnEventHandler ColumnAdded;

        protected virtual void OnColumnAdded(object dataGridView, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnAdded?.Invoke(dataGridView, e);
        }

        public event DataGridViewColumnEventHandler ColumnRemoved;

        protected virtual void OnColumnRemoved(object dataGridView, DataGridViewColumnEventArgs e)
            => ColumnRemoved?.Invoke(dataGridView, e);

        #endregion Events
    }
}