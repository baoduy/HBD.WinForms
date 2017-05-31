using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using HBD.Framework;
using HBD.WinForms.Base;

namespace HBD.WinForms.Design
{
    public sealed class PropertiesSelectionTypeEditor : UITypeEditor
    {
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var service = (IWindowsFormsEditorService) provider?.GetService(typeof(IWindowsFormsEditorService));
            if (service == null) return value;

            using (var editorUi = CreateContainControl(context, service, value))
            {
                service.DropDownControl(editorUi);
                return editorUi.SelectedItem ?? value;
            }
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            => UITypeEditorEditStyle.DropDown;

        private ListBox CreateContainControl(ITypeDescriptorContext context, IWindowsFormsEditorService service,
            object value)
        {
            if (context.Instance == null) return null;

            var listBox = new ListBox {MinimumSize = new Size(120, 300)};
            var editItem = value == null ? string.Empty : value.ToString();

            var obj = context.Instance;
            if (obj is IValidation)
                obj = ((IValidation) obj).ValidationControl;

            foreach (
                var p in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.CanRead))
                listBox.Items.Add(p.Name);

            if (editItem.IsNotNullOrEmpty() && listBox.Items.Contains(editItem))
                listBox.SelectedItem = editItem;

            listBox.SelectedIndexChanged += (s, e) => service.CloseDropDown();
            return listBox;
        }
    }
}