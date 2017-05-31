using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms.Design;

namespace HBD.WinForms.Design
{
    public sealed class EnumTypeEditor : UITypeEditor
    {
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            // Validate parameter(s).
            if (provider == null)
                return value;
            if (value == null)
                return value;

            // Validate value is a enum type with Flags attribute.
            if (!value.GetType().IsEnum)
                return value;

            //object[] attributes = value.GetType().GetCustomAttributes(typeof(FlagsAttribute), false);
            //if ((attributes == null) || (attributes.Length == 0))
            //{
            //    return value;
            //}

            // Show panel.
            var service = (IWindowsFormsEditorService) provider.GetService(typeof(IWindowsFormsEditorService));
            if (service == null) return value;

            using (var control = new EnumEditorUI(value))
            {
                service.DropDownControl(control);

                // Create new enum value.
                var type = value.GetType();
                var newValue = Activator.CreateInstance(type);
                var field = type.GetFields(BindingFlags.Public | BindingFlags.Instance)[0];
                field.SetValue(newValue, control.EditValue);

                return newValue;
            }
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            => UITypeEditorEditStyle.DropDown;
    }
}