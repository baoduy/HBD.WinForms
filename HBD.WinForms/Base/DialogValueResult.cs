using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    public sealed class DialogValueResult
    {
        public DialogValueResult(DialogResult dialogResult, object value)
        {
            DialogResult = dialogResult;
            Value = value;
        }

        public DialogResult DialogResult { get; private set; }
        public object Value { get; private set; }
    }
}