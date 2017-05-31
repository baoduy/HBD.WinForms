namespace HBD.WinForms.UserControls
{
    partial class DoubleDataGridView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            this.DataSource?.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.LeftDataGrid = new HBD.WinForms.UserControls.DataGridViewExtended();
            this.RightDataGrid = new HBD.WinForms.UserControls.DataGridViewExtended();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainer, 2);
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 26);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.LeftDataGrid);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.RightDataGrid);
            this.splitContainer.Size = new System.Drawing.Size(594, 520);
            this.splitContainer.SplitterDistance = 299;
            this.splitContainer.TabIndex = 0;
            // 
            // leftDataGrid
            // 
            this.LeftDataGrid.AllowUserToAddRows = false;
            this.LeftDataGrid.AllowUserToDeleteRows = false;
            this.LeftDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LeftDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LeftDataGrid.ColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LeftDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftDataGrid.Location = new System.Drawing.Point(0, 0);
            this.LeftDataGrid.Name = "LeftDataGrid";
            this.LeftDataGrid.ReadOnly = true;
            this.LeftDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.LeftDataGrid.Size = new System.Drawing.Size(299, 520);
            this.LeftDataGrid.TabIndex = 0;
            this.LeftDataGrid.SelectionModeChanged += new System.EventHandler(this.dataGrid_SelectionModeChanged);
            this.LeftDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OnCellBeginEdit);
            this.LeftDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEndEdit);
            this.LeftDataGrid.CellErrorTextChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellErrorTextChanged);
            this.LeftDataGrid.CellErrorTextNeeded += new System.Windows.Forms.DataGridViewCellErrorTextNeededEventHandler(this.OnCellErrorTextNeeded);
            this.LeftDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OnCellFormatting);
            this.LeftDataGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellLeave);
            this.LeftDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseClick);
            this.LeftDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseDoubleClick);
            this.LeftDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseDown);
            this.LeftDataGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellMouseEnter);
            this.LeftDataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellMouseLeave);
            this.LeftDataGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseMove);
            this.LeftDataGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseUp);
            this.LeftDataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.OnCellPainting);
            this.LeftDataGrid.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.OnCellParsing);
            this.LeftDataGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.OnCellStateChanged);
            this.LeftDataGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValidated);
            this.LeftDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.OnCellValidating);
            this.LeftDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            this.LeftDataGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.OnColumnAdded);
            this.LeftDataGrid.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.OnColumnRemoved);
            this.LeftDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OnDataBindingComplete);
            this.LeftDataGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.OnRowPostPaint);
            this.LeftDataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.OnRowPrePaint);
            this.LeftDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnRowsAdded);
            this.LeftDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsRemoved);
            this.LeftDataGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGrid_Scroll);
            this.LeftDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // rightDataGrid
            // 
            this.RightDataGrid.AllowUserToAddRows = false;
            this.RightDataGrid.AllowUserToDeleteRows = false;
            this.RightDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RightDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RightDataGrid.ColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RightDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightDataGrid.Location = new System.Drawing.Point(0, 0);
            this.RightDataGrid.Name = "RightDataGrid";
            this.RightDataGrid.ReadOnly = true;
            this.RightDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.RightDataGrid.Size = new System.Drawing.Size(291, 520);
            this.RightDataGrid.TabIndex = 0;
            this.RightDataGrid.SelectionModeChanged += new System.EventHandler(this.dataGrid_SelectionModeChanged);
            this.RightDataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OnCellBeginEdit);
            this.RightDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEndEdit);
            this.RightDataGrid.CellErrorTextChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellErrorTextChanged);
            this.RightDataGrid.CellErrorTextNeeded += new System.Windows.Forms.DataGridViewCellErrorTextNeededEventHandler(this.OnCellErrorTextNeeded);
            this.RightDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OnCellFormatting);
            this.RightDataGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellLeave);
            this.RightDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseClick);
            this.RightDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseDoubleClick);
            this.RightDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseDown);
            this.RightDataGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellMouseEnter);
            this.RightDataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellMouseLeave);
            this.RightDataGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseMove);
            this.RightDataGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseUp);
            this.RightDataGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.OnCellPainting);
            this.RightDataGrid.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.OnCellParsing);
            this.RightDataGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.OnCellStateChanged);
            this.RightDataGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValidated);
            this.RightDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.OnCellValidating);
            this.RightDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            this.RightDataGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.OnColumnAdded);
            this.RightDataGrid.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.OnColumnRemoved);
            this.RightDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OnDataBindingComplete);
            this.RightDataGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.OnRowPostPaint);
            this.RightDataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.OnRowPrePaint);
            this.RightDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnRowsAdded);
            this.RightDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsRemoved);
            this.RightDataGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGrid_Scroll);
            this.RightDataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.leftLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 549);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabel.Location = new System.Drawing.Point(5, 5);
            this.leftLabel.Margin = new System.Windows.Forms.Padding(5);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(290, 13);
            this.leftLabel.TabIndex = 0;
            this.leftLabel.Text = "Left Title";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.Location = new System.Drawing.Point(305, 5);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(290, 13);
            this.rightLabel.TabIndex = 1;
            this.rightLabel.Text = "Right Title";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoubleDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoubleDataGridView";
            this.Size = new System.Drawing.Size(600, 549);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
    }
}
