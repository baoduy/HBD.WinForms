using System;
using System.Windows.Forms;

namespace HBD.WinForms.Dialogs
{
    public partial class SqlConnectionDialog : Form
    {
        public SqlConnectionDialog()
        {
            InitializeComponent();
        }

        public string ConnectionString
        {
            get { return sqlConnectionControl.ConnectionString; }
            set { sqlConnectionControl.ConnectionString = value; }
        }

        private void bun_OK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }
    }
}