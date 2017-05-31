using HBD.Data.Comparisons;
using HBD.Framework;
using HBD.WinForms.Exceptions;
using HBD.WinForms.Properties;
using HBD.WinForms.UserControls;
using System.ComponentModel;
using System.Windows.Forms;

namespace HBD.WinForms.Validation
{
    public class CompareValidatior : DataTypeValidatior
    {
        public CompareValidatior(IContainer container) : base(container)
        {
        }

        //public string InvalidErrorMessage { get; set; }
        public Control CompareControl { get; set; }

        public string CompareValue { get; set; }

        [DefaultValue(CompareOperation.Equals)]
        public CompareOperation Operation { get; set; } = CompareOperation.Equals;

        protected override void UpdateDefaultErrorMessage()
        {
            var name = nameof(CompareControl);
            var value = CompareValue;

            if (CompareControl != null)
            {
                value = CompareControl.GetDefaultValue()?.ToString() ?? string.Empty;
                if (CompareControl.Parent is LabelledControl)
                    name = ((LabelledControl)CompareControl.Parent).Title;
            }

            DefaultErrorMessage = string.Format(Resources.Validation_CompareDefaultMessage,
                Operation.GetName().ToLower(),
                value.IsNotNullOrEmpty() ? value : name);
        }

        protected override bool Validate(object value)
        {
            if (CompareControl.IsNull() && CompareValue.IsNullOrEmpty())
                throw new ValidationException($"{nameof(CompareControl)} or {nameof(CompareValue)} are invalid.");

            var compareValue = CompareControl == null ? CompareValue : CompareControl.GetValueFromProperty(ValidationProperty);

            if (value.IsNull()) return true;
            if (compareValue.IsNull()) return true;

            object cValue;
            object ccValue;

            if (!TryParse(value, out cValue)) return false;
            if (!TryParse(compareValue, out ccValue)) return false;

            UpdateDefaultErrorMessage();
            return cValue.CompareTo(Operation, ccValue);
        }
    }
}