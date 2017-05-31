using System;
using System.ComponentModel;
using HBD.WinForms.Properties;

namespace HBD.WinForms.Attributes
{
    [Localizable(false)]
    [AttributeUsage(AttributeTargets.All)]
    public class ResourceableCategoryAttribute : CategoryAttribute
    {
        public ResourceableCategoryAttribute(string categoryKey) : base(categoryKey)
        {
        }

        protected override string GetLocalizedString(string value) => Resources.ResourceManager.GetString(value);
    }
}