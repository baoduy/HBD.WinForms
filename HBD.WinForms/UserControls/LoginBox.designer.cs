namespace HBD.WinForms.UserControls
{
    partial class LoginBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBox));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.ch_RememberPassword = new System.Windows.Forms.CheckBox();
            this.validationManager1 = new HBD.WinForms.Validation.ValidationManager(this.components);
            this.txt_Password_RequiredValidatior3 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.txt_UserName_RequiredValidatior2 = new HBD.WinForms.Validation.RequiredValidatior(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ch_RememberPassword, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Password.Location = new System.Drawing.Point(72, 29);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(178, 20);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            this.validationManager1.SetValidators(this.txt_Password, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.txt_Password_RequiredValidatior3))});
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_UserName.Location = new System.Drawing.Point(72, 3);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(178, 20);
            this.txt_UserName.TabIndex = 0;
            this.validationManager1.SetValidators(this.txt_UserName, new HBD.WinForms.Base.IValidation[] {
            ((HBD.WinForms.Base.IValidation)(this.txt_UserName_RequiredValidatior2))});
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // ch_RememberPassword
            // 
            this.ch_RememberPassword.AutoSize = true;
            this.ch_RememberPassword.Location = new System.Drawing.Point(72, 55);
            this.ch_RememberPassword.Name = "ch_RememberPassword";
            this.ch_RememberPassword.Size = new System.Drawing.Size(125, 17);
            this.ch_RememberPassword.TabIndex = 2;
            this.ch_RememberPassword.Text = "Remember password";
            this.ch_RememberPassword.UseVisualStyleBackColor = true;
            // 
            // validationManager1
            // 
            this.validationManager1.ContainerControl = this;
            this.validationManager1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationManager1.Icon")));
            // 
            // txt_Password_RequiredValidatior3
            // 
            this.txt_Password_RequiredValidatior3.ErrorMessage = "Please fill out the require field.";
            this.txt_Password_RequiredValidatior3.ValidationControl = this.txt_Password;
            this.txt_Password_RequiredValidatior3.ValidationProperty = "Text";
            // 
            // txt_UserName_RequiredValidatior2
            // 
            this.txt_UserName_RequiredValidatior2.ErrorMessage = "Please fill out the require field.";
            this.txt_UserName_RequiredValidatior2.ValidationControl = this.txt_UserName;
            this.txt_UserName_RequiredValidatior2.ValidationProperty = "Text";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(100, 58);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(271, 79);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.CheckBox ch_RememberPassword;
        private Validation.ValidationManager validationManager1;
        private Validation.RequiredValidatior txt_Password_RequiredValidatior3;
        private Validation.RequiredValidatior txt_UserName_RequiredValidatior2;
    }
}
