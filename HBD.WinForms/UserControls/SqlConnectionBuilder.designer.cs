using System.ComponentModel;

namespace HBD.WinForms.UserControls
{
    partial class SqlConnectionBuilder
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
            this.DisposeSqlHelper();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlConnectionBuilder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ch_SQL = new System.Windows.Forms.RadioButton();
            this.ch_Window = new System.Windows.Forms.RadioButton();
            this.loginControl = new HBD.WinForms.UserControls.LoginBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_DBName = new System.Windows.Forms.ComboBox();
            this.btTest = new System.Windows.Forms.Button();
            this.validationManager = new HBD.WinForms.Validation.ValidationManager(this.components);
            this.txt_ServerName_RequiredValidatior1 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.cb_DBName_RequiredValidatior2 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ServerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginControl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_DBName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btTest, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authentication:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ServerName.Location = new System.Drawing.Point(87, 3);
            this.txt_ServerName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(280, 20);
            this.txt_ServerName.TabIndex = 0;
            this.validationManager.SetValidators(this.txt_ServerName, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.txt_ServerName_RequiredValidatior1))});
            this.txt_ServerName.TextChanged += new System.EventHandler(this.txt_ServerName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ch_SQL);
            this.panel1.Controls.Add(this.ch_Window);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(87, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 25);
            this.panel1.TabIndex = 4;
            // 
            // ch_SQL
            // 
            this.ch_SQL.AutoSize = true;
            this.ch_SQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.ch_SQL.Location = new System.Drawing.Point(64, 0);
            this.ch_SQL.Name = "ch_SQL";
            this.ch_SQL.Size = new System.Drawing.Size(80, 25);
            this.ch_SQL.TabIndex = 1;
            this.ch_SQL.Text = "SQL Server";
            this.ch_SQL.UseVisualStyleBackColor = true;
            this.ch_SQL.CheckedChanged += new System.EventHandler(this.ch_SQL_CheckedChanged);
            // 
            // ch_Window
            // 
            this.ch_Window.AutoSize = true;
            this.ch_Window.Checked = true;
            this.ch_Window.Dock = System.Windows.Forms.DockStyle.Left;
            this.ch_Window.Location = new System.Drawing.Point(0, 0);
            this.ch_Window.Name = "ch_Window";
            this.ch_Window.Size = new System.Drawing.Size(64, 25);
            this.ch_Window.TabIndex = 0;
            this.ch_Window.TabStop = true;
            this.ch_Window.Text = "Window";
            this.ch_Window.UseVisualStyleBackColor = true;
            // 
            // loginControl
            // 
            this.loginControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginControl.Enabled = false;
            this.loginControl.Location = new System.Drawing.Point(92, 64);
            this.loginControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.loginControl.MinimumSize = new System.Drawing.Size(100, 58);
            this.loginControl.Name = "loginControl";
            this.loginControl.ShowRememberPassword = false;
            this.loginControl.Size = new System.Drawing.Size(282, 58);
            this.loginControl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Database:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_DBName
            // 
            this.cb_DBName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_DBName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_DBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_DBName.FormattingEnabled = true;
            this.cb_DBName.Location = new System.Drawing.Point(87, 132);
            this.cb_DBName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.cb_DBName.Name = "cb_DBName";
            this.cb_DBName.Size = new System.Drawing.Size(280, 21);
            this.cb_DBName.TabIndex = 2;
            this.validationManager.SetValidators(this.cb_DBName, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.cb_DBName_RequiredValidatior2))});
            this.cb_DBName.DropDown += new System.EventHandler(this.cb_DBName_DropDown);
            this.cb_DBName.SelectedIndexChanged += new System.EventHandler(this.cb_DBName_SelectedIndexChanged);
            this.cb_DBName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cb_DBName_DropDown);
            // 
            // btTest
            // 
            this.btTest.AutoSize = true;
            this.btTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTest.Location = new System.Drawing.Point(3, 159);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(78, 25);
            this.btTest.TabIndex = 3;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.bt_Test_Click);
            // 
            // validationManager
            // 
            this.validationManager.ContainerControl = this;
            this.validationManager.Icon = ((System.Drawing.Icon)(resources.GetObject("validationManager.Icon")));
            // 
            // txt_ServerName_RequiredValidatior1
            // 
            this.txt_ServerName_RequiredValidatior1.ErrorMessage = "Server name is required.";
            this.txt_ServerName_RequiredValidatior1.ValidationControl = this.txt_ServerName;
            this.txt_ServerName_RequiredValidatior1.ValidationProperty = "Text";
            // 
            // cb_DBName_RequiredValidatior2
            // 
            this.cb_DBName_RequiredValidatior2.ErrorMessage = "Database name is required.";
            this.cb_DBName_RequiredValidatior2.ValidationControl = this.cb_DBName;
            this.cb_DBName_RequiredValidatior2.ValidationProperty = "Text";
            // 
            // SqlConnectionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(100, 150);
            this.Name = "SqlConnectionBuilder";
            this.Size = new System.Drawing.Size(382, 188);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ch_Window;
        private System.Windows.Forms.RadioButton ch_SQL;
        private LoginBox loginControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_DBName;
        private System.Windows.Forms.Button btTest;
        private Validation.ValidationManager validationManager;
        private Validation.RequiredValidatior txt_ServerName_RequiredValidatior1;
        private Validation.RequiredValidatior cb_DBName_RequiredValidatior2;
    }
}
