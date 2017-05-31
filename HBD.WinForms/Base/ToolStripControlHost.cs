using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using HBD.Framework;

namespace HBD.WinForms.Base
{
    [ToolboxItem(false)]
    [ToolStripItemDesignerAvailability(
         ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripControlHost<TControl> : ToolStripControlHost where TControl : Control
    {
        protected ToolStripControlHost() : base(typeof(TControl).CreateInstance() as Control)
        {
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(null)]
        public TControl ChildControl => (TControl) Control;

        public override Size GetPreferredSize(Size constrainingSize)
            => new Size(ChildControl.Width > Width ? ChildControl.Width : Width, 0);
    }
}