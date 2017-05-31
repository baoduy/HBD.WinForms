using System.ComponentModel;
using HBD.Framework.Core;
using HBD.WinForms.Base;

namespace HBD.WinForms.Validation
{
    public class CustomValidatior : BaseValidatior
    {
        public CustomValidatior(IContainer container) : base(container)
        {
        }

        public ICustomValidation Validator { get; set; }

        public override bool Validate()
        {
            Guard.ArgumentIsNotNull(Validator, nameof(Validator));
            return Validator.Validate(this, ValidationControl);
        }
    }
}