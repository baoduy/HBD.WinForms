using HBD.Framework;
using HBD.WinForms.Base;
using HBD.WinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBD.WinForms
{
    public static class WindowControlExtension
    {
        #region TreeView

        public static IEnumerable<TreeNode> Descendants(this TreeNodeCollection @this)
        {
            foreach (var node in @this.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                    yield return child;
            }
        }

        #endregion TreeView

        public static DisabledWithCursorWaitor<T> DisableWithWaitCursor<T>(this T @this) where T : ContainerControl
        => new DisabledWithCursorWaitor<T>(@this);

        /// <summary>
        /// AppendText To TextBox. Will call Invoke method if required.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value"></param>
        public static void InvokeAppendText(this TextBoxBase @this, string value)
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke((MethodInvoker)delegate { @this.AppendText(value); });
                return;
            }
            @this.AppendText(value);
        }

        public static Task InvokeAppendTextAsync(this TextBoxBase @this, string value)
            => Task.Run(() => @this.InvokeAppendText(value));

        //public static CursorWaitor<T> UseCursorWaitor<T>(this T @this) where T : IDisposable => new CursorWaitor<T>(@this);

        public static CursorWaitor UseCursorWaitor(this object @this) => new CursorWaitor();

        #region Show Message

        public static void ShowErrorMessage(Exception exception)
            => ShowErrorMessage(exception.Message);

        public static void ShowErrorMessage(string message)
            => MessageBox.Show(message, Resources.ShowMessage_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowInfoMessage(string message)
            => MessageBox.Show(message, Resources.ShowMessage_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static DialogResult ShowConfirmationMessage(string message)
            => MessageBox.Show(message, Resources.ShowMessage_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        public static void ShowErrorMessage(this Component @this, Exception exception)
            => ShowErrorMessage(exception.Message);

        public static void ShowErrorMessage(this Component @this, string message)
            => MessageBox.Show(message, Resources.ShowMessage_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowInfoMessage(this Component @this, string message)
            => MessageBox.Show(message, Resources.ShowMessage_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static DialogResult ShowConfirmationMessage(this Component @this, string message)
            => MessageBox.Show(message, Resources.ShowMessage_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        #endregion Show Message

        #region Control

        public static IEnumerable<Control> Descendants(this Control.ControlCollection @this,
            Func<Control, bool> condition = null)
        {
            foreach (Control c in @this)
            {
                yield return c;

                if ((condition != null) && !condition.Invoke(c)) continue;

                foreach (var child in c.Controls.Descendants(condition))
                    yield return child;
            }
        }

        private static void Enqueue<T>(this Queue<T> @this, IEnumerable<T> collection)
        {
            if (collection == null) return;
            foreach (var i in collection)
                @this.Enqueue(i);
        }

        //public static IEnumerable<TControl> Find<TControl>(this TControl @this, bool includeChilds = true) where TControl : Control
        //    => @this.Find(typeof(TControl), includeChilds).Cast<TControl>();

        //public static IEnumerable<TControl> Find<TControl>(this TControl @this, bool includeChilds = true) where TControl : IControl
        //    => @this.Find(typeof(TControl), includeChilds).Cast<TControl>();

        //public static IEnumerable<TControl> Find<TControl>(this TControl @this, Type controlType, bool includeChilds = true) where TControl : IControl
        //{
        //    if (@this != null)
        //    {
        //        var queue = new Queue<TControl>();
        //        queue.Enqueue(@this);
        //        queue.Enqueue(@this.Controls.Cast<TControl>());

        // while (queue.Count > 0) { var control = queue.Dequeue();

        // if (includeChilds && !control.Equals( @this)) queue.Enqueue(control.Controls.Cast<TControl>());

        //            if (controlType.IsInstanceOfType(control))
        //                yield return control;
        //        }
        //    }
        //}

        public static Control FindByName(this Control @this, string controlName)
        {
            if (@this == null) return null;

            var queue = new Queue<Control>();
            queue.Enqueue(@this);

            while (queue.Count > 0)
            {
                var control = queue.Dequeue();
                queue.Enqueue(control.Controls.Cast<Control>());

                if (control.Name.EqualsIgnoreCase(controlName))
                    return control;
            }

            return null;
        }

        #endregion Control

        #region DataGridView

        public static void CopyToClipboard(this DataGridView @this)
        {
            var data = @this.GetClipboardContent();
            if (data != null) Clipboard.SetDataObject(data, true);
        }

        public static void PasteFromClipboard(this DataGridView @this)
        {
            var text = Clipboard.GetText();
            var lines = text.Split('\n');

            if (@this.CurrentCell == null)
            {
                if (@this.RowCount == 0)
                    @this.Rows.Add();
                @this.CurrentCell = @this.Rows[0].Cells[0];
            }

            var startColumnIndex = @this.CurrentCell.ColumnIndex;
            var startRowIndex = @this.CurrentCell.RowIndex;
            @this.ClearSelection();
            @this.EndEdit();

            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.IsNullOrEmpty()) continue;

                if (@this.Rows[startRowIndex + i].IsNewRow
                    || (startRowIndex + i == @this.RowCount))
                    @this.Rows.Add();

                var items = line.Split('\t');
                for (var j = 0; (j < items.Length) && (j < @this.ColumnCount); j++)
                    try
                    {
                        var value = items[j];
                        if (value.IsNotNullOrEmpty())
                            value = value.Replace("\r", string.Empty);

                        if (startColumnIndex + j >= @this.ColumnCount) break;
                        var cell = @this.Rows[startRowIndex + i].Cells[startColumnIndex + j];
                        cell.Value = value.ChangeType(cell.ValueType);
                    }
                    catch
                    {
                        // ignored
                    }
            }
        }

        #endregion DataGridView
    }
}