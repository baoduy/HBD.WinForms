namespace HBD.WinForms.DataAdapters
{
    partial class ExcelReaderAdapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelReaderAdapter));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSheets = new System.Windows.Forms.ComboBox();
            this.fileBrowser = new HBD.WinForms.UserControls.FileBrowserBar();
            this.validationManager1 = new HBD.WinForms.Validation.ValidationManager(this.components);
            this.FileBrowserControl_RequiredValidatior1 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.cbSheets_RequiredValidatior2 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.cbSheets_InListValidatior1 = new HBD.WinForms.Validation.InExprectedListValidatior(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.fileBrowser, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.cbSheets, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(250, 64);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sheet";
            // 
            // cbSheets
            // 
            this.cbSheets.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSheets.FormattingEnabled = true;
            this.cbSheets.Location = new System.Drawing.Point(44, 37);
            this.cbSheets.Name = "cbSheets";
            this.cbSheets.Size = new System.Drawing.Size(183, 21);
            this.cbSheets.TabIndex = 2;
            this.validationManager1.SetValidators(this.cbSheets, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.cbSheets_RequiredValidatior2)),
            ((HBD.WinForms.Base.IValidation)(this.cbSheets_InListValidatior1))});
            // 
            // fileBrowser
            // 
            this.tableLayoutPanel.SetColumnSpan(this.fileBrowser, 2);
            this.fileBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileBrowser.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            this.fileBrowser.Location = new System.Drawing.Point(3, 3);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(224, 28);
            this.fileBrowser.TabIndex = 0;
            this.fileBrowser.Title = "Excel";
            this.validationManager1.SetValidators(this.fileBrowser, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.FileBrowserControl_RequiredValidatior1))});
            this.fileBrowser.Change += new System.EventHandler(this.fileBrowserControl1_Change);
            // 
            // validationManager1
            // 
            this.validationManager1.ContainerControl = this;
            this.validationManager1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationManager1.Icon")));
            // 
            // FileBrowserControl_RequiredValidatior1
            // 
            this.FileBrowserControl_RequiredValidatior1.ErrorMessage = "File path is required.";
            this.FileBrowserControl_RequiredValidatior1.ValidationControl = this.fileBrowser;
            this.FileBrowserControl_RequiredValidatior1.ValidationProperty = "SelectedPath";
            // 
            // cbSheets_RequiredValidatior2
            // 
            this.cbSheets_RequiredValidatior2.ErrorMessage = "Sheet name is required.";
            this.cbSheets_RequiredValidatior2.ValidationControl = this.cbSheets;
            this.cbSheets_RequiredValidatior2.ValidationProperty = "Text";
            // 
            // cbSheets_InListValidatior1
            // 
            this.cbSheets_InListValidatior1.ErrorMessage = "Value is invalid.";
            this.cbSheets_InListValidatior1.ExpectedItemProperty = "Items";
            this.cbSheets_InListValidatior1.ValidationControl = this.cbSheets;
            this.cbSheets_InListValidatior1.ValidationProperty = "Text";
            // 
            // ExcelReaderAdapterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(5000, 64);
            this.MinimumSize = new System.Drawing.Size(150, 64);
            this.Name = "ExcelReaderAdapterControl";
            this.Size = new System.Drawing.Size(250, 64);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private HBD.WinForms.UserControls.FileBrowserBar fileBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSheets;
        private HBD.WinForms.Validation.ValidationManager validationManager1;
        private HBD.WinForms.Validation.RequiredValidatior FileBrowserControl_RequiredValidatior1;
        private HBD.WinForms.Validation.RequiredValidatior cbSheets_RequiredValidatior2;
        private HBD.WinForms.Validation.InExprectedListValidatior cbSheets_InListValidatior1;
    }
}
