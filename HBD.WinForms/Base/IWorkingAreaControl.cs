using System.ComponentModel;
using System.Windows.Forms;
using HBD.WinForms.Design;

namespace HBD.WinForms.Base
{
    [Designer(typeof(WorkingAreaDesigner))]
    public interface IWorkingAreaControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        Panel WorkingArea { get; }
    }
}