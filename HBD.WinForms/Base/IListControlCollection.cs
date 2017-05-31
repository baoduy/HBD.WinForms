using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    public interface IListControlCollection : IControl
    {
        Type ChildrenControlType { get; }
        IList<Control> ChildrenControls { get; }
        int MaxChildrenControl { get; set; }

        Control AddNewControl(params object[] parameters);

        void Clear();

        event ControlEventHandler ControlAdded;

        event ControlEventHandler ControlRemoved;

        void RemoveControl();

        //event EventHandler AllowancePropertiesChanged;
    }
}