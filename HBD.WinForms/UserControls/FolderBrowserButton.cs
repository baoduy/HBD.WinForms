using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(FolderBrowserDialog))]
    [DefaultValue("SelectedPath")]
    [DefaultBindingProperty("SelectedPath")]
    [DefaultEvent("Change")]
    public partial class FolderBrowserButton : Button, IPathBrowser
    {
        public FolderBrowserButton()
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
                _selectedPath = value;
                this.OnChange(EventArgs.Empty);
            }
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
            folderBrowserDialog.SelectedPath = this.SelectedPath;
            var result = folderBrowserDialog.ShowDialog();
            this.SelectedPath = folderBrowserDialog.SelectedPath;
            return result;
        }
    }
}