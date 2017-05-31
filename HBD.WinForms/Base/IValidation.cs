using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using HBD.WinForms.Design;

namespace HBD.WinForms.Base
{
    [Editor(typeof(ValidationTypeEditor), typeof(UITypeEditor))]
    public interface IValidation : IComponent
    {
        Control ValidationControl { get; set; }
        Control DisplayErrorControl { get; set; }

        //ValidationType ValidateType { get; }
        string ErrorMessage { get; }

        bool ShowErrorMessgeDialog { get; set; }
        bool Enabled { get; set; }

        bool Validate();
    }
}