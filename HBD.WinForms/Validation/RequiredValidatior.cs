using System.ComponentModel;
using HBD.Framework;
using HBD.WinForms.Properties;

namespace HBD.WinForms.Validation
{
    public class RequiredValidatior : BaseValidatior
    {
        public RequiredValidatior(IContainer container) : base(container)
        {
            DefaultErrorMessage = Resources.Validation_RequireDefaultMessage;
        }

        protected override bool Validate(object value) => value.IsNotNull();
    }
}