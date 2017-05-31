using HBD.Framework;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.DataAdapters
{
    [DefaultValue("DataTable")]
    [DefaultEvent("TextChanged")]
    public partial class CsvReaderAdapter : UserControl, IDataAdapterControl
    {
        private const string FixedLenghError = "Fixed length must be a number and greater than 0.";
        private const string FileNotFound = "File not found.";
        private const string FixedLengthEmpty = "Please specify the Column Lengths.";

        public CsvReaderAdapter()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual DataTable DataTable
        {
            get
            {
                if (!Validate()) return null;

                var tb = new DataTable();
                tb.LoadFromCsv(fileBrowser.SelectedPath, op =>
                {
                    op.FirstRowIsHeader = ch_FirstRowIsHeader.Checked;
                    op.Dilimiters = GetDelimiter();
                    op.FieldWidths = GetFieldWidths();
                });
                return tb;
            }
        }

        private void CheckEnabled()
        {
            var valid = fileBrowser.IsExisted();

            rbDelimiter.Enabled = valid;
            rbFixedLengh.Enabled = valid;
            ch_FirstRowIsHeader.Enabled = valid;

            cbDelimiter.Visible = cbDelimiter.Enabled = rbDelimiter.Checked && valid;
            data_FixedLength.Visible = data_FixedLength.Enabled = !rbDelimiter.Checked && valid;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == cnt_AddRow)
                data_FixedLength.Rows.Add();
            else if (e.ClickedItem == cnt_Copy)
                data_FixedLength.CopyToClipboard();
            else if (e.ClickedItem == cnt_Paste)
                data_FixedLength.PasteFromClipboard();
            else if (data_FixedLength.CurrentRow != null)
                data_FixedLength.DeleteSelectedRows();
        }

        private void data_FixedLength_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.IsNull()) return;
            if (e.FormattedValue.IsNumber()) return;

            this.ShowErrorMessage(FixedLenghError);
            e.Cancel = true;
        }

        private void fileBrowser_Change(object sender, EventArgs e)
        {
            Text = Path.GetFileName(fileBrowser.SelectedPath);
            CheckEnabled();
        }

        private string[] GetDelimiter()
        {
            if (!rbDelimiter.Checked) return null;

            string value;
            switch (cbDelimiter.SelectedIndex)
            {
                case 0:
                    value = ",";
                    break;

                case 1:
                    value = "|";
                    break;

                default:
                    value = cbDelimiter.Text;
                    break;
            }

            return new[] { value };
        }

        private int[] GetFieldWidths()
        {
            if (!rbFixedLengh.Checked) return null;
            return
                data_FixedLength.Rows.Cast<DataGridViewRow>()
                    .Select(r => r.Cells[col_FixedLength.Name].Value.ChangeType<int>())
                    .ToArray();
        }

        private void rbDelimiter_CheckedChanged(object sender, EventArgs e) => CheckEnabled();
    }
}