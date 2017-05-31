using HBD.WinForms.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(TextBox))]
    [DefaultProperty("Text")]
    [DefaultBindingProperty("Text")]
    [DefaultEvent("Click")]
    public partial class SearchTextBox : UserControl, IButtonControl
    {
        private Image _searchImage = Resources.search;

        public SearchTextBox()
        {
            InitializeComponent();
        }

        [Localizable(true)]
        public Image SearchImage
        {
            get { return _searchImage; }
            set
            {
                if (_searchImage == value) return;
                _searchImage = value;
                btnSearch.Image = value;
            }
        }

        [Localizable(true)]
        public Image CancelImage { get; set; } = Resources.cancel;

        /// <summary>
        /// Auto click when text had been entered into search box.
        /// </summary>
        [DefaultValue(false)]
        public bool AutoClick { get; set; } = false;

        [DefaultValue(null)]
        public override string Text
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        [DefaultValue(DialogResult.None)]
        public DialogResult DialogResult { get; set; } = DialogResult.None;

        /// <summary>
        /// NotifyDefault is not support on this control.
        /// </summary>
        /// <param name="value"></param>
        public void NotifyDefault(bool value)
        {
        }

        public void PerformClick()
        {
            if (btnSearch.Image == SearchImage)
                btnSearch.Image = CancelImage;
            else
            {
                btnSearch.Image = SearchImage;
                Text = string.Empty;
            }

            OnClick(EventArgs.Empty);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Height = txtSearch.Height + 9;
            base.OnSizeChanged(e);
        }

        private void btnSearch_Click(object sender, EventArgs e) => PerformClick();

        private void btnSearch_MouseEnter(object sender, EventArgs e)
            => btnSearch.BackColor = Color.SkyBlue;

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Transparent;
            if (Text.Length <= 0)
                btnSearch.Image = SearchImage;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                PerformClick();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (AutoClick)
                PerformClick();
        }
    }
}