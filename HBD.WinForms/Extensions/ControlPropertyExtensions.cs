using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using HBD.Framework;

namespace HBD.WinForms
{
    public static class ControlPropertyExtensions
    {
        public static PropertyInfo GetDefaultProperty(this Control @this)
        {
            if (@this == null) return null;
            var name = @this.GetDefaultPropertyName();
            return name.IsNotNullOrEmpty() ? @this.GetType().GetProperty(name) : null;
        }

        public static string GetDefaultPropertyName(this Control @this)
        {
            var binding = @this?.GetType().GetCustomAttributes<DefaultBindingPropertyAttribute>().FirstOrDefault();
            return binding?.Name ?? string.Empty;

            //var attribute = @this.GetAttribute<DefaultPropertyAttribute>();
            //return attribute == null ? string.Empty : attribute.Name;
        }

        public static object GetDefaultValue(this Control @this)
            => @this.GetDefaultProperty()?.GetValue(@this);

        public static void SetDefaultValue(this Control @this, object value)
        {
            var property = @this.GetDefaultProperty();
            property?.SetValue(@this, value);
        }

        /// <summary>
        ///     Set Value to User Control. Will call Invoke method if required.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="this"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        public static void SetValue<TControl>(this TControl @this, Expression<Func<TControl, object>> property,
            object value) where TControl : Control
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke((MethodInvoker) delegate { @this.SetValue(property, value); });
                return;
            }

            var pro = property.GetProperties().FirstOrDefault();
            pro?.SetValue(@this, value);
        }

        public static Task SetValueAsync<TControl>(this TControl @this, Expression<Func<TControl, object>> property,
            object value) where TControl : Control
        => Task.Run(() => @this.SetValue(property, value));
    }
}