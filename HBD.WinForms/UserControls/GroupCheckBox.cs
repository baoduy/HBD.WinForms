using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap(typeof(GroupBox))]
    public partial class GroupCheckBox : GroupBox
    {
        private readonly DockStyle _collapsedDock = DockStyle.Top;

        private readonly int _collpasedHigh = 20;
        private DockStyle _currentDock = DockStyle.None;
        private int _currentHigh;

        public GroupCheckBox()
        {
            InitializeComponent();
            Text = string.Empty;
        }

        [DefaultValue(true)]
        public bool CheckboxVisible
        {
            get { return checkBox.Visible; }
            set { checkBox.Visible = value; }
        }

        /// <summary>
        ///     Auto collapsed when the check box is unchecked.
        /// </summary>
        [DefaultValue(false)]
        public bool AutoCollapsed { get; set; } = false;

        [DefaultValue(true)]
        public bool Checked
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            checkBox.Font = Font;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            checkBox.ForeColor = ForeColor;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (Parent == null)
            {
                checkBox.Visible = false;
                return;
            }

            // Re-parent the CheckBox so it's not n the GroupBox.
            Parent.Controls.Add(checkBox);

            CheckBoxPositionArrange();

            checkBox.Visible = true;
            checkBox_CheckedChanged(this, EventArgs.Empty);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            CheckBoxPositionArrange();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            checkBox.Text = Text;
        }

        // Enable or disable the GroupBox.
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode || !CheckboxVisible) return;

            SuspendLayout();

            var ischecked = checkBox.Checked;
            Enabled = ischecked;

            if (_currentDock == DockStyle.None)
                _currentDock = Dock;

            if (_currentHigh == 0)
                _currentHigh = Size.Height;

            if (AutoCollapsed)
            {
                Dock = ischecked ? _currentDock : _collapsedDock;
                Size = new Size(Size.Width, ischecked ? _currentHigh : _collpasedHigh);

                foreach (Control control in Controls)
                    control.Visible = ischecked;
            }

            ResumeLayout();
        }

        private void CheckBoxPositionArrange()
        {
            checkBox.Text = Text;
            // Adjust the CheckBox's location.
            checkBox.Location = new Point(Left + 9, Top);
            // Move the CheckBox to the top of the stacking order.
            checkBox.BringToFront();
        }
    }
}