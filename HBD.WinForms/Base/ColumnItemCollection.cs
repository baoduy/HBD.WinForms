using HBD.Framework.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HBD.WinForms.Base
{
    public class ColumnItemCollection : List<ColumnItem>, ICloneable<ColumnItemCollection>
    {
        public ColumnItemCollection()
        {
        }

        public ColumnItemCollection(DataColumnCollection columns) : this(columns?.Cast<DataColumn>())
        {
        }

        public ColumnItemCollection(IEnumerable<DataColumn> columns)
        {
            if (columns == null) return;
            foreach (var col in columns)
                Add(col.ColumnName, col.DataType);
        }

        public ColumnItemCollection(IEnumerable<ColumnItem> columns)
        {
            foreach (var col in columns)
                Add(col.Name, col.DataType);
        }

        public ColumnItem this[string name]
            => this.FirstOrDefault(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        public ColumnItemCollection Clone() => new ColumnItemCollection(this);

        object ICloneable.Clone() => Clone();

        public void Add(string name, Type dataType)
        {
            Guard.ArgumentIsNotNull(name, "Name");
            Guard.ArgumentIsNotNull(dataType, "DataType");

            if (this[name] != null) return;
            base.Add(new ColumnItem { Name = name, DataType = dataType });
        }

        public static implicit operator ColumnItemCollection(DataColumnCollection columns)
            => new ColumnItemCollection(columns);

        public void Remove(string name)
        {
            var item = this[name];
            if (item != null)
                Remove(item);
        }
    }
}