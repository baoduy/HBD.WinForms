using HBD.Data.Comparisons;
using HBD.Data.Comparisons.Base;
using HBD.Framework.Core;
using HBD.WinForms.Base;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [ToolboxBitmap("Resources.filter.ico")]
    public partial class DataGridViewFilter : UserControl
    {
        private IFilterableControl _filterableControl;

        public DataGridViewFilter()
        {
            InitializeComponent();
        }

        public IFilterableControl FilterableControl
        {
            get { return _filterableControl; }
            set
            {
                if (_filterableControl == value) return;

                if (_filterableControl != null)
                    _filterableControl.ColumnNamesChanged -= _filterableControl_ColumnNamesChanged;
                _filterableControl = value;
                _filterableControl.ColumnNamesChanged += _filterableControl_ColumnNamesChanged;
            }
        }

        public void LoadControlData()
        {
            if ((this == null) || (FilterableControl == null)) return;
            Enabled = FilterableControl.ColumnItems.Count > 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadControlData();
        }

        private void _filterableControl_ColumnNamesChanged(object sender, EventArgs e) => LoadControlData();

        private void bt_Filter_Click(object sender, EventArgs e)
        {
            Guard.ArgumentIsNotNull(FilterableControl, "FilterableControl");

            //if (!this.Validate()) return;

            ICondition filter = null;

            foreach (var f in filterCollection.ChildrenControls.Cast<FilterItem>().Select(c => c.Item))
            {
                if (filter == null)
                {
                    filter = f;
                    continue;
                }

                filter = ch_MatchAnyRule.Checked ? filter.Or(f) : filter.And(f);
            }

            FilterableControl.Filter(filter);
            ParentForm.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e) => filterCollection.Clear();

        private void filterCollection_ChildrenControlAdded(object sender, ControlEventArgs e)
        {
            if (FilterableControl == null) return;
            var control = e.Control as FilterItem;
            if (control != null) control.DataSource = FilterableControl.ColumnItems.Clone();
        }
    }
}