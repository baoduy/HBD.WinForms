using HBD.Data.Comparisons;
using HBD.Data.Comparisons.Base;
using HBD.WinForms.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [DefaultProperty("Item")]
    public partial class FilterItem : UserControl
    {
        private Control _valueControl;

        public FilterItem()
        {
            InitializeComponent();
            Operation = CompareOperation.Contains;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(null)]
        public ColumnItemCollection DataSource
        {
            get { return cb_Field.DataSource as ColumnItemCollection; }
            set { cb_Field.DataSource = value; }
        }

        private string FieldName { get; set; }
        private CompareOperation Operation { get; set; }
        private object Value { get; set; }

        //Don't keep FilterItem object as it may referenced by another control
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(null)]
        public ValueCondition Item
        {
            get { return new ValueCondition(FieldName, Operation, Value); }
            set
            {
                if (value == null) return;

                FieldName = value.Field;
                Operation = value.Operation;
                Value = value.Value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Height = cb_Field.Height + 6;
            LoadValueControl();
        }

        //public override void LoadControlData()
        //{
        //    base.LoadControlData();
        //    this.cb_Field.Text = this.FieldName;
        //}

        private void cb_Field_SelectedIndexChanged(object sender, EventArgs e)
        {
            FieldName = cb_Field.Text;
            cb_Ope.DataSource = GetOperation();
            cb_Ope.SelectedItem = Operation;
        }

        private void cb_Ope_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operation = (CompareOperation)cb_Ope.SelectedItem;
        }

        private void control_TextChanged(object sender, EventArgs e)
        {
            Value = ((Control)sender).GetDefaultValue();
        }

        private CompareOperation[] GetOperation()
        {
            //if (!this.ValidateControls(this.cb_Field)) return null;

            var col = cb_Field.SelectedItem as ColumnItem;
            if ((col == null) || (col.DataType == typeof(string)))
                return new[]
                {
                    CompareOperation.Contains,
                    CompareOperation.NotContains,
                    CompareOperation.StartsWith,
                    CompareOperation.EndsWith,
                    CompareOperation.Equals
                };

            if (col.DataType == typeof(DateTime))
                return new[]
                {
                    CompareOperation.GreaterThan,
                    CompareOperation.GreaterThanOrEquals,
                    CompareOperation.LessThan,
                    CompareOperation.LessThanOrEquals,
                    CompareOperation.Equals
                };

            if (col.DataType != null)
                return new[]
                {
                    CompareOperation.GreaterThan,
                    CompareOperation.GreaterThanOrEquals,
                    CompareOperation.LessThan,
                    CompareOperation.LessThanOrEquals,
                    CompareOperation.Equals
                };

            return new[]
            {
                CompareOperation.Contains,
                CompareOperation.NotContains,
                CompareOperation.StartsWith,
                CompareOperation.EndsWith,
                CompareOperation.GreaterThan,
                CompareOperation.GreaterThanOrEquals,
                CompareOperation.LessThan,
                CompareOperation.LessThanOrEquals,
                CompareOperation.Equals
            };
        }

        private void LoadValueControl()
        {
            var col = cb_Field.SelectedItem as ColumnItem;

            if ((col == null) || (col.DataType == typeof(string)))
                _valueControl = new TextBox();
            else if (col.DataType == typeof(DateTime))
                _valueControl = new DateTimePicker();
            else
            {
                _valueControl = new NumericUpDown();
                ((NumericUpDown)_valueControl).Maximum = decimal.MaxValue;
            }

            if (_valueControl != null)
            {
                if (Value != null)
                    _valueControl.SetDefaultValue(Value);

                _valueControl.TextChanged += control_TextChanged;
                _valueControl.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(_valueControl, 2, 0);
            }
        }
    }
}