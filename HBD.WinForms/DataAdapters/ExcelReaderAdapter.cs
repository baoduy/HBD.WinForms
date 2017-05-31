using HBD.Framework;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using HBD.Framework.Data;
using HBD.Framework.Data.Excel;

namespace HBD.WinForms.DataAdapters
{
    [DefaultValue("DataTable")]
    [DefaultEvent("TextChanged")]
    public partial class ExcelReaderAdapter : UserControl, IDataAdapterControl
    {
        public ExcelReaderAdapter()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual DataTable DataTable
        {
            get
            {
                using (var adapter = new ExcelAdapter(fileBrowser.SelectedPath))
                {
                    return adapter.ReadData(cbSheets.Text)?.ToDataTable();
                }
            }
        }

        private void fileBrowserControl1_Change(object sender, EventArgs e)
        {
            if (fileBrowser.SelectedPath.IsNullOrEmpty()) return;

            Text = Path.GetFileName(fileBrowser.SelectedPath);

            cbSheets.Items.Clear();
            using (var adapter = new ExcelAdapter(fileBrowser.SelectedPath))
            {
                cbSheets.Items.AddRange(adapter.SheetNames);
            }
        }
    }
}