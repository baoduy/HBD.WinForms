using System.Windows.Forms;
using HBD.WinForms.Validation;

namespace HBD.WinForms.Base
{
    public interface ICustomValidation
    {
        bool Validate(CustomValidatior parent, Control validateControl);
    }
}