using HBD.QueryBuilders;
using HBD.QueryBuilders.Context;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.DataAdapters
{
    [DefaultValue("DataTable")]
    [DefaultEvent("TextChanged")]
    public partial class SqlReaderAdapter : UserControl, IDataAdapterControl
    {
        public SqlReaderAdapter()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual DataTable DataTable
        {
            get
            {
                using (var adapter = new SqlQueryBuilderContext(sqlConnection.ConnectionString))
                {
                    var select = adapter.CreateSelectQuery();
                    select.From(cb_Tables.Text);
                    return adapter.ExecuteTable(select);
                }
            }
        }

        private void cb_Tables_DropDown(object sender, EventArgs e)
        {
            if (cb_Tables.Items.Count > 0) return;
            cb_Tables.Items.AddRange(sqlConnection.SelecteDataBaseInfo.GetSchemaInfo().Tables.Select(t => t.Name).ToArray());
        }

        private void cb_Tables_SelectedIndexChanged(object sender, EventArgs e) => Text = cb_Tables.Text;

        private void sqlConnection_Changed(object sender, EventArgs e) => cb_Tables.Items.Clear();
    }
}