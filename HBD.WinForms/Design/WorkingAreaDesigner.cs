using System.ComponentModel;
using System.Windows.Forms.Design;
using HBD.WinForms.Base;

namespace HBD.WinForms.Design
{
    public sealed class WorkingAreaDesigner : ScrollableControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            var workingArea = (Control as IWorkingAreaControl)?.WorkingArea;
            if (workingArea == null) return;
            EnableDesignMode(workingArea, "WorkingArea");
        }
    }
}