using HBD.Framework;
using HBD.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms
{
    public static class WinFormsExtension
    {
        //public static ColumnNamesCollection ToList(this DataColumnCollection columns)
        //{
        //    return new ColumnNamesCollection(columns);
        //}

        //private static FieldInfo GetLayoutSuspendCountField()
        //{
        //    return typeof(Control).GetField("layoutSuspendCount", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        //}

        //public static byte GetLayoutSuspendCount(this Form form)
        //{
        //    var field = GetLayoutSuspendCountField();
        //    if (field != null)
        //        return (byte)field.GetValue(form);
        //    return 0;
        //}

        //public static byte GetLayoutSuspendCount(this UserControl control)
        //{
        //    var field = GetLayoutSuspendCountField();
        //    if (field != null)
        //        return (byte)field.GetValue(control);
        //    return 0;
        //}

        //public static bool IsLayoutSuspended(this Form form)
        //{
        //    return form.GetLayoutSuspendCount() > 0;
        //}

        //public static bool IsLayoutSuspended(this UserControl control)
        //{
        //    return control.GetLayoutSuspendCount() > 0;
        //}

        /// <summary>
        /// Find control/children controls by name
        /// </summary>
        /// <param name="control"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static object FindControl(this Control control, string name)
        {
            Guard.ArgumentIsNotNull(control, "control");

            var queue = new Queue<object>();
            queue.Enqueue(control);

            do
            {
                var item = queue.Dequeue();
                if (item is Control)
                {
                    var co = item as Control;

                    if (co.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                        return co;
                    if (co.Controls.Count > 0)
                        queue.EnqueueArrange(co.Controls.Cast<object>());
                }

                if (item is ToolStrip)
                {
                    var tool = (ToolStrip)item;
                    if (tool.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                        return tool;
                    if (tool.Items.Count > 0)
                        queue.EnqueueArrange(tool.Items.Cast<object>());
                }
                else if (item is ToolStripItem)
                {
                    var tool = (ToolStripItem)item;
                    if (tool.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                        return tool;
                }
            } while (queue.Count > 0);

            return null;
        }

        public static void HideAllColumns(this DataGridView grid)
        {
            grid.ClearSelection();
            foreach (DataGridViewColumn col in grid.Columns)
                col.Visible = false;
        }

        public static void HideAllRows(this DataGridView grid)
        {
            grid.ClearSelection();
            for (var i = 0; i < grid.RowCount; i++)
                grid.Rows[i].Visible = false;
        }

        public static void ShowAllColumns(this DataGridView grid)
        {
            foreach (DataGridViewColumn col in grid.Columns)
                col.Visible = true;
        }

        public static void SortColumnHeaders(this DataGridView grid, params string[] excludeColumns)
        {
            for (var i = 0; i < grid.ColumnCount - 1; i++)
            {
                var coli = grid.Columns[i];

                if ((excludeColumns != null)
                    && excludeColumns.Contains(coli.HeaderText))
                    continue;

                for (var j = i + 1; j < grid.ColumnCount; j++)
                {
                    var colj = grid.Columns[j];

                    if (coli.HeaderText.CompareTo(colj.HeaderText) <= 0) continue;
                    var tmp = coli.DisplayIndex;
                    coli.DisplayIndex = colj.DisplayIndex;
                    colj.DisplayIndex = tmp;
                }
            }
        }

        public static void SortColumnHeadersByIndexOfFields(this DataGridView grid, IEnumerable<string> fields)
        {
            if (fields == null) return;

            var i = 0;
            foreach (var f in fields.Where(f => grid.Columns.Contains(f)))
                grid.Columns[f].DisplayIndex = i++;
        }
    }
}