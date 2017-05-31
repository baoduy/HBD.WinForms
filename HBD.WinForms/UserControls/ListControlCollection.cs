using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HBD.Framework;
using HBD.WinForms.Base;
using HBD.WinForms.Design;

namespace HBD.WinForms.UserControls
{
    [DefaultEvent("ChildrenControlAdded")]
    [Designer(typeof(WorkingAreaDesigner))]
    [ToolboxBitmap(typeof(ListBox))]
    public partial class ListControlCollection : WorkingAreaControlBase, IListControlCollection
    {
        public ListControlCollection()
        {
            InitializeComponent();

            ChildrenControls = new List<Control>();
            bt_AddRemove.ListControl = this;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public bool ShowAddRemoveButton
        {
            get { return bt_AddRemove.Visible; }
            set { bt_AddRemove.Visible = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public override Panel WorkingArea => controlTemplatePanel;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Control> ChildrenControls { get; }

        [DefaultValue(0)]
        public int MaxChildrenControl { get; set; } = 0;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Type ChildrenControlType => controlTemplatePanel.TemplateControlType;

        public virtual Control AddNewControl(params object[] parameters)
        {
            if ((MaxChildrenControl > 0) && (ChildrenControls.Count == MaxChildrenControl))
                throw new Exception($"The number of children control cannot add more than {MaxChildrenControl}.");

            tableColumns.SuspendLayout();

            if (ChildrenControlType == null)
            {
                this.ShowErrorMessage("Please provide ChildrenControlType");
                return null;
            }

            var control = ChildrenControlType.CreateInstance(parameters) as Control;
            if (control == null)
                throw new Exception($"Cannot create instance of {ChildrenControlType.Name}");

            control.Dock = DockStyle.Top;
            ChildrenControls.Add(control);

            var newIndex = tableColumns.GetRow(bt_AddRemove);
            if (ChildrenControls.Count > 0)
                newIndex += 1;

            tableColumns.Controls.Add(control, 0, newIndex);
            tableColumns.SetRow(bt_AddRemove, newIndex);

            //this.validationManager.SetValidateType(control, new RequiredValidatior(this.components));

            OnControlAdded(new ControlEventArgs(control));

            tableColumns.ResumeLayout();
            return control;
        }

        public virtual void RemoveControl()
        {
            if (ChildrenControls.Count > 0)
            {
                var control = ChildrenControls[ChildrenControls.Count - 1];
                ChildrenControls.RemoveAt(ChildrenControls.Count - 1);
                tableColumns.Controls.Remove(control);
                control.Dispose();

                var index = tableColumns.GetRow(bt_AddRemove);
                tableColumns.SetRow(bt_AddRemove, index - 1);
                OnControlRemoved(new ControlEventArgs(control));
            }
        }

        public virtual void Clear()
        {
            if (ChildrenControls == null) return;

            foreach (var c in ChildrenControls)
            {
                tableColumns.Controls.Remove(c);
                c.Dispose();
            }

            tableColumns.SetRow(bt_AddRemove, tableColumns.GetRow(bt_AddRemove) - ChildrenControls.Count + 1);
            ChildrenControls.Clear();

            OnControlRemoved(new ControlEventArgs(null));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode) return;

            VScroll = false;
            tableColumns.Dock = DockStyle.Top;

            //Initial template control
            if (ChildrenControlType != null) return;

            if (WorkingArea.Controls.Count <= 0)
            {
                this.ShowErrorMessage("The control template hasn't defined.");
                Enabled = false;
                return;
            }

            tableColumns.Controls.Remove(WorkingArea);
        }
    }
}