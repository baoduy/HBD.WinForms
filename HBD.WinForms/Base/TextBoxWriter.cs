using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HBD.Framework.Core;

namespace HBD.WinForms.Base
{
    public class TextBoxWriter : TextWriter
    {
        private readonly TextBox _textBox;

        public TextBoxWriter(TextBox textBox)
        {
            Guard.ArgumentIsNotNull(textBox, nameof(textBox));
            _textBox = textBox;
        }

        public override Encoding Encoding => Encoding.Unicode;

        public override void Write(string value) => _textBox.InvokeAppendText(value);

        public override Task WriteAsync(string value) => _textBox.InvokeAppendTextAsync(value);

        public override void WriteLine(string value) => Write($"{value}{NewLine}");

        public override Task WriteLineAsync(string value) => WriteAsync($"{value}{NewLine}");
    }
}