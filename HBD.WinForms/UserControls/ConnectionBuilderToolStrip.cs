using System;
using System.ComponentModel;
using HBD.WinForms.Base;

namespace HBD.WinForms.UserControls
{
    [DefaultEvent("Change")]
    [DefaultProperty("ConnectionString")]
    [DefaultBindingProperty("ConnectionString")]
    public class ConnectionBuilderToolStrip : ToolStripControlHost<ConnectionBuilder>
    {
        [DefaultValue("Connection String")]
        public string Title
        {
            get { return ChildControl.Title; }
            set { ChildControl.Title = value; }
        }

        [DefaultValue("Create New")]
        public string CreateNewText
        {
            get { return ChildControl.CreateNewText; }
            set { ChildControl.CreateNewText = value; }
        }

        [DefaultValue("Update")]
        public string UpdateText
        {
            get { return ChildControl.UpdateText; }
            set { ChildControl.UpdateText = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectionString
        {
            get { return ChildControl.ConnectionString; }
            set { ChildControl.ConnectionString = value; }
        }

        public event EventHandler Change
        {
            add { ChildControl.Change += value; }
            remove { ChildControl.Change -= value; }
        }
    }
}