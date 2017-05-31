using HBD.WinForms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBD.WinForms.TestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_AddRemoveButton_Click(object sender, EventArgs e)
        {
            using (var fr = new AddRemoveButtonTest())
                fr.ShowDialog(this);
        }

        private void btn_SqlQueryBuilderDialog_Click(object sender, EventArgs e)
        {
            using (var fr = new SqlConnectionDialog())
            {
                fr.ShowDialog(this);
                MessageBox.Show(fr.ConnectionString);
            }
        }
    }
}