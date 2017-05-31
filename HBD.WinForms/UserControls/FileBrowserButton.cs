using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(OpenFileDialog))]
    [DefaultValue("SelectedPath")]
    [DefaultBindingProperty("SelectedPath")]
    [DefaultEvent("Change")]
    public partial class FileBrowserButton : Button, IPathBrowser
    {
        public FileBrowserButton()
        {
            InitializeComponent();
        }

        private string _selectedPath;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedPath
        {
            get { return _selectedPath; }
            set
            {
                if (this._selectedPath == value) return;
                this._selectedPath = value;
                this.OnChange(EventArgs.Empty);
            }
        }

        [DefaultValue("All Files|*.*")]
        public string Filter
        {
            get { return openFileDialog.Filter; }
            set { openFileDialog.Filter = value; }
        }

        public event EventHandler Change;

        protected virtual void OnChange(EventArgs e) => Change?.Invoke(this, e);

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            OpenDialog();
        }

        public DialogResult OpenDialog()
        {
            openFileDialog.FileName = this.SelectedPath;
            var result = openFileDialog.ShowDialog();
            this.SelectedPath = openFileDialog.FileName;
            return result;
        }
    }
}