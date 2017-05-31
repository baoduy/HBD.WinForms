using HBD.Data.Comparisons;
using System.Data;

namespace HBD.WinForms.DataAdapters
{
    partial class CsvReaderAdapter
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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CsvReaderAdapter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbDelimiter = new System.Windows.Forms.RadioButton();
            this.data_FixedLength = new HBD.WinForms.UserControls.DataGridViewExtended();
            this.col_FixedLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cnt_AddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.cnt_DeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cnt_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cnt_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.fileBrowser = new HBD.WinForms.UserControls.FileBrowserBar();
            this.ch_FirstRowIsHeader = new System.Windows.Forms.CheckBox();
            this.rbFixedLengh = new System.Windows.Forms.RadioButton();
            this.cbDelimiter = new System.Windows.Forms.ComboBox();
            this.validationManager1 = new HBD.WinForms.Validation.ValidationManager(this.components);
            this.data_FixedLength_CollectionCountValidator1 = new HBD.WinForms.Validation.CollectionCountValidator(this.components);
            this.FileBrowserControl_RequiredValidatior1 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.cbDelimiter_RequiredValidatior2 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_FixedLength)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.rbDelimiter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.data_FixedLength, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fileBrowser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ch_FirstRowIsHeader, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbFixedLengh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbDelimiter, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rbDelimiter
            // 
            this.rbDelimiter.AutoSize = true;
            this.rbDelimiter.Checked = true;
            this.rbDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDelimiter.Enabled = false;
            this.rbDelimiter.Location = new System.Drawing.Point(5, 67);
            this.rbDelimiter.Margin = new System.Windows.Forms.Padding(5);
            this.rbDelimiter.Name = "rbDelimiter";
            this.rbDelimiter.Size = new System.Drawing.Size(65, 17);
            this.rbDelimiter.TabIndex = 0;
            this.rbDelimiter.TabStop = true;
            this.rbDelimiter.Text = "Delimiter";
            this.rbDelimiter.UseVisualStyleBackColor = true;
            this.rbDelimiter.CheckedChanged += new System.EventHandler(this.rbDelimiter_CheckedChanged);
            // 
            // data_FixedLength
            // 
            this.data_FixedLength.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_FixedLength.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.data_FixedLength.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_FixedLength.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_FixedLength});
            this.data_FixedLength.ColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tableLayoutPanel1.SetColumnSpan(this.data_FixedLength, 2);
            this.data_FixedLength.ContextMenuStrip = this.contextMenuStrip;
            this.data_FixedLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_FixedLength.Enabled = false;
            this.data_FixedLength.Location = new System.Drawing.Point(3, 119);
            this.data_FixedLength.Name = "data_FixedLength";
            this.data_FixedLength.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.data_FixedLength.Size = new System.Drawing.Size(302, 278);
            this.data_FixedLength.TabIndex = 3;
            this.validationManager1.SetValidators(this.data_FixedLength, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.data_FixedLength_CollectionCountValidator1))});
            this.data_FixedLength.Visible = false;
            this.data_FixedLength.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.data_FixedLength_CellValidating);
            // 
            // col_FixedLength
            // 
            this.col_FixedLength.HeaderText = "Column Length Definition";
            this.col_FixedLength.Name = "col_FixedLength";
            this.col_FixedLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnt_AddRow,
            this.cnt_DeleteRow,
            this.toolStripSeparator1,
            this.cnt_Copy,
            this.cnt_Paste});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(188, 98);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // cnt_AddRow
            // 
            this.cnt_AddRow.Name = "cnt_AddRow";
            this.cnt_AddRow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cnt_AddRow.Size = new System.Drawing.Size(187, 22);
            this.cnt_AddRow.Text = "&Add new row";
            // 
            // cnt_DeleteRow
            // 
            this.cnt_DeleteRow.Name = "cnt_DeleteRow";
            this.cnt_DeleteRow.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cnt_DeleteRow.Size = new System.Drawing.Size(187, 22);
            this.cnt_DeleteRow.Text = "&Delete row";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // cnt_Copy
            // 
            this.cnt_Copy.Name = "cnt_Copy";
            this.cnt_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cnt_Copy.Size = new System.Drawing.Size(187, 22);
            this.cnt_Copy.Text = "&Copy";
            // 
            // cnt_Paste
            // 
            this.cnt_Paste.Name = "cnt_Paste";
            this.cnt_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cnt_Paste.Size = new System.Drawing.Size(187, 22);
            this.cnt_Paste.Text = "&Paste";
            // 
            // fileBrowser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fileBrowser, 2);
            this.fileBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileBrowser.Filter = "CSV File|*.csv";
            this.fileBrowser.Location = new System.Drawing.Point(3, 3);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(302, 29);
            this.fileBrowser.TabIndex = 4;
            this.validationManager1.SetValidators(this.fileBrowser, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.FileBrowserControl_RequiredValidatior1))});
            this.fileBrowser.Change += new System.EventHandler(this.fileBrowser_Change);
            // 
            // ch_FirstRowIsHeader
            // 
            this.ch_FirstRowIsHeader.AutoSize = true;
            this.ch_FirstRowIsHeader.Checked = true;
            this.ch_FirstRowIsHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.ch_FirstRowIsHeader, 2);
            this.ch_FirstRowIsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ch_FirstRowIsHeader.Enabled = false;
            this.ch_FirstRowIsHeader.Location = new System.Drawing.Point(5, 40);
            this.ch_FirstRowIsHeader.Margin = new System.Windows.Forms.Padding(5);
            this.ch_FirstRowIsHeader.Name = "ch_FirstRowIsHeader";
            this.ch_FirstRowIsHeader.Size = new System.Drawing.Size(298, 17);
            this.ch_FirstRowIsHeader.TabIndex = 5;
            this.ch_FirstRowIsHeader.Text = "First row is header";
            this.ch_FirstRowIsHeader.UseVisualStyleBackColor = true;
            // 
            // rbFixedLengh
            // 
            this.rbFixedLengh.AutoSize = true;
            this.rbFixedLengh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbFixedLengh.Enabled = false;
            this.rbFixedLengh.Location = new System.Drawing.Point(125, 67);
            this.rbFixedLengh.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.rbFixedLengh.Name = "rbFixedLengh";
            this.rbFixedLengh.Size = new System.Drawing.Size(178, 17);
            this.rbFixedLengh.TabIndex = 2;
            this.rbFixedLengh.Text = "Fixed Length";
            this.rbFixedLengh.UseVisualStyleBackColor = true;
            this.rbFixedLengh.CheckedChanged += new System.EventHandler(this.rbDelimiter_CheckedChanged);
            // 
            // cbDelimiter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbDelimiter, 2);
            this.cbDelimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDelimiter.Enabled = false;
            this.cbDelimiter.FormattingEnabled = true;
            this.cbDelimiter.Items.AddRange(new object[] {
            "Comma ( , )",
            "Vertical bar ( | )"});
            this.cbDelimiter.Location = new System.Drawing.Point(3, 92);
            this.cbDelimiter.Name = "cbDelimiter";
            this.cbDelimiter.Size = new System.Drawing.Size(302, 21);
            this.cbDelimiter.TabIndex = 1;
            this.cbDelimiter.Text = "Comma ( , )";
            this.validationManager1.SetValidators(this.cbDelimiter, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.cbDelimiter_RequiredValidatior2))});
            this.cbDelimiter.Visible = false;
            // 
            // validationManager1
            // 
            this.validationManager1.ContainerControl = this;
            this.validationManager1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationManager1.Icon")));
            // 
            // data_FixedLength_CollectionCountValidator1
            // 
            this.data_FixedLength_CollectionCountValidator1.ErrorMessage = "Column length definition cannot be empty.";
            this.data_FixedLength_CollectionCountValidator1.ExpectedCountAmount = 1;
            this.data_FixedLength_CollectionCountValidator1.Operation = CompareOperation.GreaterThan;
            this.data_FixedLength_CollectionCountValidator1.ValidationControl = this.data_FixedLength;
            this.data_FixedLength_CollectionCountValidator1.ValidationProperty = "Rows";
            // 
            // FileBrowserControl_RequiredValidatior1
            // 
            this.FileBrowserControl_RequiredValidatior1.ErrorMessage = "The file path cannot be empty.";
            this.FileBrowserControl_RequiredValidatior1.ValidationControl = this.fileBrowser;
            this.FileBrowserControl_RequiredValidatior1.ValidationProperty = "SelectedPath";
            // 
            // cbDelimiter_RequiredValidatior2
            // 
            this.cbDelimiter_RequiredValidatior2.ErrorMessage = "Delimiter is required.";
            this.cbDelimiter_RequiredValidatior2.ValidationControl = this.cbDelimiter;
            this.cbDelimiter_RequiredValidatior2.ValidationProperty = "Text";
            // 
            // CsvReaderAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CsvReaderAdapter";
            this.Size = new System.Drawing.Size(321, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_FixedLength)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbDelimiter;
        private System.Windows.Forms.ComboBox cbDelimiter;
        private System.Windows.Forms.RadioButton rbFixedLengh;
        private HBD.WinForms.UserControls.DataGridViewExtended data_FixedLength;
        private HBD.WinForms.UserControls.FileBrowserBar fileBrowser;
        private System.Windows.Forms.CheckBox ch_FirstRowIsHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cnt_AddRow;
        private System.Windows.Forms.ToolStripMenuItem cnt_DeleteRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cnt_Copy;
        private System.Windows.Forms.ToolStripMenuItem cnt_Paste;
        private HBD.WinForms.Validation.ValidationManager validationManager1;
        private HBD.WinForms.Validation.RequiredValidatior FileBrowserControl_RequiredValidatior1;
        private HBD.WinForms.Validation.RequiredValidatior cbDelimiter_RequiredValidatior2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FixedLength;
        private Validation.CollectionCountValidator data_FixedLength_CollectionCountValidator1;
    }
}
