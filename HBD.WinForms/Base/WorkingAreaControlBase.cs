using HBD.WinForms.Design;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    [Designer(typeof(WorkingAreaDesigner))]
    [ToolboxBitmap(typeof(Panel))]
    public class WorkingAreaControlBase : UserControl, IWorkingAreaControl
    {
        protected WorkingAreaControlBase()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual Panel WorkingArea { get; protected set; } = new Panel();
    }
}