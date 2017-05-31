using HBD.Framework;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(FolderBrowserDialog))]
    [DefaultEvent("Change")]
    [DefaultProperty("SelectedPath")]
    [DefaultBindingProperty("SelectedPath")]
    public partial class FolderBrowserBar : UserControl, IPathBrowser
    {
        public FolderBrowserBar()
        {
            InitializeComponent();
            Height = txt_Folder.Height + txt_Folder.Margin.Top * 3;
        }

        [DefaultValue("Folder")]
        public string Title
        {
            get { return lb_Title.Text; }
            set { lb_Title.Text = value; }
        }

        [DefaultValue("Browse")]
        public string ButtonText
        {
            get { return btn_Browse.Text; }
            set { btn_Browse.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue("")]
        public string SelectedPath
        {
            get { return btn_Browse.SelectedPath; }
            set { btn_Browse.SelectedPath = value; }
        }

        public event EventHandler Change;

        public DialogResult OpenDialog() => btn_Browse.OpenDialog();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsExisted() => Directory.Exists(SelectedPath);

        protected virtual void OnChange(EventArgs e) => Change?.Invoke(this, e);

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            txt_Folder.Focus();
        }

        private void btn_Browse_Change(object sender, EventArgs e)
        {
            txt_Folder.Text = btn_Browse.SelectedPath;
            this.OnChange(e);
        }

        private void txt_Folder_DoubleClick(object sender, EventArgs e)
        {
            if (this.SelectedPath.IsNotNullOrEmpty() && Directory.Exists(this.SelectedPath))
                Process.Start(this.SelectedPath);
            else this.btn_Browse.OpenDialog();
        }

        private void txt_Folder_TextChanged(object sender, EventArgs e)
            => this.SelectedPath = this.txt_Folder.Text;
    }
}