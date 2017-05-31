using System;

namespace HBD.WinForms.Base
{
    public class ColumnItem
    {
        public string Name { get; set; }
        public Type DataType { get; set; }

        public override string ToString() => Name;
    }
}