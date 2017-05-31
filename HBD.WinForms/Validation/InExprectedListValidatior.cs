using HBD.Framework;
using HBD.WinForms.Design;
using HBD.WinForms.Exceptions;
using HBD.WinForms.Properties;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;

namespace HBD.WinForms.Validation
{
    /// <summary>
    /// This validate will validate the value of an property of control that must be in an expected list.
    /// </summary>
    public class InExprectedListValidatior : BaseValidatior
    {
        public InExprectedListValidatior(IContainer container) : base(container)
        {
            DefaultErrorMessage = Resources.Validate_InvalidMessage;
        }

        [Editor(typeof(PropertiesSelectionTypeEditor), typeof(UITypeEditor))]
        public string ExpectedItemProperty { get; set; }

        [DefaultValue(null)]
        public string[] ExpectedItems { get; set; }

        protected override bool Validate(object value)
        {
            if (value.IsNull()) return true;

            var items = ExpectedItems ?? ValidationControl.GetValueFromProperty(ExpectedItemProperty) as IEnumerable;
            var enumerable = items as object[] ?? items?.Cast<object>().ToArray();

            if (enumerable.IsNull()) throw new ValidationException("The expected items cannot be empty.");
            return enumerable.Any(v => v == value);
        }
    }
}