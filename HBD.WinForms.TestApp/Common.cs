using System.Drawing;
using System.Windows.Forms;
using HBD.WinForms.Base;

namespace HBD.WinForms.TestApp
{
    public static class Common
    {
        public static DialogValueResult ShowDialog<T>() where T : Control, new()
        {
            using (var form = new Form())
            {
                var c = new T();
                form.Controls.Add(c);

                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.AutoSize = true;
                form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                return new DialogValueResult(form.ShowDialog(), c.GetDefaultValue());
            }
        }

        public static DialogValueResult ShowDialog<T>(Size size) where T : Control, new()
        {
            using (var form = new Form { FormBorderStyle = FormBorderStyle.FixedDialog, Size = size })
            {
                var c = new T { Dock = DockStyle.Fill };
                form.Controls.Add(c);

                return new DialogValueResult(form.ShowDialog(), c.GetDefaultValue());
            }
        }

        public static DialogResult ShowForm<TForm>() where TForm : Form, new()
        {
            using (var form = new TForm())
            {
                return form.ShowDialog();
            }
        }
    }
}
