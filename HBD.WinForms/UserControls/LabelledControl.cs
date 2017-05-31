using HBD.WinForms.Attributes;
using HBD.WinForms.Base;
using HBD.WinForms.Design;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [NotAllowValidation]
    [ProvideProperty("Title", typeof(Control))]
    [DefaultProperty("Title")]
    [Designer(typeof(WorkingAreaDesigner))]
    [ToolboxBitmap(typeof(Label))]
    public partial class LabelledControl : WorkingAreaControlBase, IExtenderProvider
    {
        private LabelledStyle _style = LabelledStyle.Vertical;

        public LabelledControl()
        {
            InitializeComponent();
        }

        [DefaultValue(LabelledStyle.Horizontal)]
        public LabelledStyle Style
        {
            get { return _style; }
            set
            {
                if (_style == value) return;
                _style = value;
                InitialContainer();
            }
        }

        public string Title
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public override Panel WorkingArea => panel;

        public bool CanExtend(object extendee)
            =>
            extendee is Control && !(extendee is LabelledControl) &&
            (extendee == panel.Controls.Cast<Control>().FirstOrDefault());

        public string GetTitle(Control control) => Title;

        public void SetTitle(Control control, string title) => Title = title;

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (panel.Controls.Count == 0) return;
            var control = panel.Controls[0];
            control.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            OnMove(e);
            InitialContainer();
        }

        private void InitialContainer()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            if (Style == LabelledStyle.Horizontal)
            {
                tableLayoutPanel1.ColumnCount = 1;
                tableLayoutPanel1.RowCount = 2;

                tableLayoutPanel1.RowStyles.Add(new RowStyle()); //Auto Size
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); //100%

                tableLayoutPanel1.Controls.Add(label, 0, 0);
                tableLayoutPanel1.Controls.Add(panel, 0, 1);
            }
            else
            {
                tableLayoutPanel1.ColumnCount = 2;
                tableLayoutPanel1.RowCount = 1;

                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle()); //Auto Size
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); //100%

                tableLayoutPanel1.Controls.Add(label, 0, 0);
                tableLayoutPanel1.Controls.Add(panel, 1, 0);
            }
        }

        private void label_Click(object sender, EventArgs e) => OnGotFocus(e);
    }

    public enum LabelledStyle
    {
        Horizontal = 1,
        Vertical = 2
    }
}