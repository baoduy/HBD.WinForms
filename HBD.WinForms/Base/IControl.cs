using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    public interface IControl : IDropTarget, IComponent, ISynchronizeInvoke, IWin32Window, IBindableComponent,
        IDisposable
    {
        Control.ControlCollection Controls { get; }
    }
}