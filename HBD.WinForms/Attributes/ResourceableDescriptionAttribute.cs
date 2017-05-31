using System;
using System.ComponentModel;
using HBD.WinForms.Properties;

namespace HBD.WinForms.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class ResourceableDescriptionAttribute : DescriptionAttribute
    {
        public ResourceableDescriptionAttribute([Localizable(false)] string descriptionKey)
        {
            DescriptionKey = descriptionKey;
        }

        public string DescriptionKey { get; set; }
        public override string Description => Resources.ResourceManager.GetString(DescriptionKey);
    }
}