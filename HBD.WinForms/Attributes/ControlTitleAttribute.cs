using System;

namespace HBD.WinForms.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ControlTitleAttribute : Attribute
    {
        public ControlTitleAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}