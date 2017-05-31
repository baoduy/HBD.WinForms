using HBD.Framework;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(OpenFileDialog))]
    [DefaultEvent("Change")]
    [DefaultProperty("SelectedPath")]
    [DefaultBindingProperty("SelectedPath")]
    public partial class FileBrowserBar : UserControl, IPathBrowser
    {
        public FileBrowserBar()
        {
            InitializeComponent();
        }

        [DefaultValue("File")]
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
        public string SelectedPath
        {
            get { return btn_Browse.SelectedPath; }
            set { this.btn_Browse.SelectedPath = value; }
        }

        [DefaultValue("All Files|*.*")]
        public string Filter
        {
            get { return btn_Browse.Filter; }
            set { btn_Browse.Filter = value; }
        }

        public event EventHandler Change;

        public DialogResult OpenDialog() => btn_Browse.OpenDialog();

        public bool IsExisted() => File.Exists(SelectedPath);

        protected virtual void OnChange(EventArgs e) => Change?.Invoke(this, e);

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            txt_FilePath.Focus();
        }

        private void btn_Browse_Change(object sender, EventArgs e)
        {
            this.txt_FilePath.Text = this.btn_Browse.SelectedPath;
            OnChange(e);
        }

        private void txt_FilePath_DoubleClick(object sender, EventArgs e)
        {
            if (this.SelectedPath.IsNotNullOrEmpty() && File.Exists(SelectedPath))
                Process.Start(SelectedPath);
            else btn_Browse.OpenDialog();
        }

        private void txt_FilePath_Leave(object sender, EventArgs e)
            => this.SelectedPath = this.txt_FilePath.Text;
    }
}