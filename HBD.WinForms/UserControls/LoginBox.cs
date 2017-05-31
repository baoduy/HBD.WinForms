using HBD.WinForms.Attributes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(TextBox))]
    [DefaultEvent("Click")]
    [NotAllowValidation]
    public partial class LoginBox : UserControl
    {
        public LoginBox()
        {
            InitializeComponent();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e) => OnTextChanged(e);

        #region Properties

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserName
        {
            get { return txt_UserName.Text; }
            set { txt_UserName.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Password
        {
            get { return txt_Password.Text; }
            set { txt_Password.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(false)]
        public bool RememberPassword
        {
            get { return ch_RememberPassword.Checked; }
            set { ch_RememberPassword.Checked = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("Remember password")]
        public string RememberPasswordText
        {
            get { return ch_RememberPassword.Text; }
            set { ch_RememberPassword.Text = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool ShowRememberPassword
        {
            get { return ch_RememberPassword.Visible; }
            set { ch_RememberPassword.Visible = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool ValidationEnabled
        {
            get { return validationManager1.Enabled; }
            set { validationManager1.Enabled = value; }
        }

        #endregion Properties
    }
}