using HBD.Framework;
using HBD.WinForms.Dialogs;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [DefaultEvent("Change")]
    [DefaultProperty("ConnectionString")]
    [DefaultBindingProperty("ConnectionString")]
    public partial class ConnectionBuilder : UserControl
    {
        public ConnectionBuilder()
        {
            InitializeComponent();
            Height = txt_ConnectionString.Height + txt_ConnectionString.Margin.Top * 3;
        }

        [DefaultValue("Connection String")]
        public string Title
        {
            get { return lb_Title.Text; }
            set { lb_Title.Text = value; }
        }

        [DefaultValue("Create New")]
        public string CreateNewText { get; set; } = "Create New";

        [DefaultValue("Update")]
        public string UpdateText { get; set; } = "Update";

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectionString
        {
            get { return txt_ConnectionString.Text; }
            set { txt_ConnectionString.Text = value; }
        }

        public event EventHandler Change;

        protected virtual SqlConnectionDialog CreateConnectionDialog()
            => new SqlConnectionDialog { ConnectionString = txt_ConnectionString.Text };

        protected virtual void OnChange(EventArgs e) => Change?.Invoke(this, e);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            btn_NewOrUpdate.Text = CreateNewText;
        }

        private void btn_NewOrUpdate_Click(object sender, EventArgs e)
        {
            using (var form = CreateConnectionDialog())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    txt_ConnectionString.Text = form.ConnectionString;
            }
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == copyToolStripMenuItem)
            {
                txt_ConnectionString.SelectAll();
                Clipboard.SetText(txt_ConnectionString.Text);
            }
            else
            {
                txt_ConnectionString.Text = Clipboard.GetText();
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            copyToolStripMenuItem.Enabled = txt_ConnectionString.Text.IsNotNullOrEmpty();
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
        }

        private void txt_ConnectionString_TextChanged(object sender, EventArgs e)
        {
            if (txt_ConnectionString.Text.IsNullOrEmpty())
                btn_NewOrUpdate.Text = CreateNewText;
            else btn_NewOrUpdate.Text = UpdateText;

            OnChange(e);
        }
    }
}