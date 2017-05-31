using System.ComponentModel;
using System.Text.RegularExpressions;
using HBD.Framework;
using HBD.Framework.Exceptions;

namespace HBD.WinForms.Validation
{
    public class RegularValidatior : BaseValidatior
    {
        public RegularValidatior(IContainer container) : base(container)
        {
        }

        public string RegularRegex { get; set; }

        protected override bool Validate(object value)
        {
            if (RegularRegex.IsNullOrEmpty())
                throw new InvalidException(nameof(RegularRegex));

            var regex = new Regex(RegularRegex);
            return regex.IsMatch(value.ToString());
        }
    }
}