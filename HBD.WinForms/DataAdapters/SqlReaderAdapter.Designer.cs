namespace HBD.WinForms.DataAdapters
{
    partial class SqlReaderAdapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlReaderAdapter));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sqlConnection = new HBD.WinForms.UserControls.SqlConnectionBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.validationManager1 = new HBD.WinForms.Validation.ValidationManager(this.components);
            this.cb_Tables_RequiredValidatior1 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.sqlConnection, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.cb_Tables, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(392, 191);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // sqlConnection
            // 
            this.sqlConnection.TestButtonVisibled = false;
            this.tableLayoutPanel.SetColumnSpan(this.sqlConnection, 2);
            this.sqlConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlConnection.Location = new System.Drawing.Point(3, 3);
            this.sqlConnection.MinimumSize = new System.Drawing.Size(100, 150);
            this.sqlConnection.Name = "sqlConnection";
            this.sqlConnection.Size = new System.Drawing.Size(386, 155);
            this.sqlConnection.TabIndex = 1;
            this.sqlConnection.Changed += new System.EventHandler(this.sqlConnection_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table:               ";
            // 
            // cb_Tables
            // 
            this.cb_Tables.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Location = new System.Drawing.Point(91, 164);
            this.cb_Tables.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(283, 21);
            this.cb_Tables.TabIndex = 3;
            this.validationManager1.SetValidators(this.cb_Tables, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.cb_Tables_RequiredValidatior1))});
            this.cb_Tables.DropDown += new System.EventHandler(this.cb_Tables_DropDown);
            this.cb_Tables.SelectedIndexChanged += new System.EventHandler(this.cb_Tables_SelectedIndexChanged);
            // 
            // validationManager1
            // 
            this.validationManager1.ContainerControl = this;
            this.validationManager1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationManager1.Icon")));
            // 
            // cb_Tables_RequiredValidatior1
            // 
            this.cb_Tables_RequiredValidatior1.ErrorMessage = "Table name is required.";
            this.cb_Tables_RequiredValidatior1.ValidationControl = this.cb_Tables;
            this.cb_Tables_RequiredValidatior1.ValidationProperty = "Text";
            // 
            // SqlReaderAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(200, 190);
            this.Name = "SqlReaderAdapter";
            this.Size = new System.Drawing.Size(392, 191);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private HBD.WinForms.UserControls.SqlConnectionBuilder sqlConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Tables;
        private HBD.WinForms.Validation.ValidationManager validationManager1;
        private HBD.WinForms.Validation.RequiredValidatior cb_Tables_RequiredValidatior1;
    }
}
