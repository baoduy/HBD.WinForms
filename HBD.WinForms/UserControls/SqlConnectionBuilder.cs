using HBD.Framework;
using HBD.Framework.Data.SqlClient;
using HBD.Framework.Data.SqlClient.Base;
using HBD.WinForms.Attributes;
using HBD.WinForms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    [DefaultProperty("ConnectionString")]
    [DefaultBindingProperty("ConnectionString")]
    [DefaultEvent("Changed")]
    [NotAllowValidation]
    public partial class SqlConnectionBuilder : UserControl, IDbConnectionControl
    {
        private bool _cannotGetDbName;
        private SqlConnectionStringBuilder _connectionString;
        private SqlClientAdapter _sqlClientAdapter;

        public SqlConnectionBuilder()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected SqlConnectionStringBuilder ConnectionStringBuilder
        {
            get
            {
                if (_connectionString == null)
                    _connectionString = new SqlConnectionStringBuilder();

                //if (IsControlDataLoaded)
                //{
                //if (!string.IsNullOrEmpty(this.txt_ServerName.Text))
                _connectionString.DataSource = txt_ServerName.Text;

                if (!string.IsNullOrEmpty(cb_DBName.Text))
                    _connectionString.InitialCatalog = cb_DBName.Text;

                if (ch_SQL.Checked)
                {
                    _connectionString.UserID = loginControl.UserName;
                    _connectionString.Password = loginControl.Password;
                    _connectionString.IntegratedSecurity = false;
                }
                else _connectionString.IntegratedSecurity = true;
                //}

                return _connectionString;
            }
        }

        [DefaultValue(true)]
        public bool TestButtonVisibled
        {
            get { return btTest.Visible; }
            set { btTest.Visible = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IReadOnlyCollection<DatabaseInfo> DatabaseInfo => SqlClientAdapter.GetDataBaseInfos();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DatabaseInfo SelecteDataBaseInfo
            => DatabaseInfo.FirstOrDefault(d => d.Name == cb_DBName.Text);

        private SqlClientAdapter SqlClientAdapter => _sqlClientAdapter ?? (_sqlClientAdapter = CreateSqlClientAdapter());

        public event EventHandler Changed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectionString
        {
            get { return ConnectionStringBuilder.ConnectionString; }
            set
            {
                try
                {
                    ConnectionStringBuilder.ConnectionString = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected virtual SqlClientAdapter CreateSqlClientAdapter() => new SqlClientAdapter(ConnectionString);

        protected virtual void OnChanged(EventArgs e) => Changed?.Invoke(this, e);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txt_ServerName.Text = ConnectionStringBuilder.DataSource.IsNullOrEmpty()
                ? "localhost"
                : ConnectionStringBuilder.DataSource;

            ch_SQL.Checked = !ConnectionStringBuilder.IntegratedSecurity;
            loginControl.UserName = ConnectionStringBuilder.UserID;
            loginControl.Password = ConnectionStringBuilder.Password;
            cb_DBName.Text = ConnectionStringBuilder.InitialCatalog;

            //this.IsControlDataLoaded = true;
        }

        private void bt_Test_Click(object sender, EventArgs e) => TestConnection();

        private void cb_DBName_DropDown(object sender, EventArgs e) => LoadDbName();

        private void cb_DBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.DisposeSqlHelper();
            OnChanged(e);
        }

        private void ch_SQL_CheckedChanged(object sender, EventArgs e) => loginControl.Enabled = ch_SQL.Checked;

        private void ClearDbNameItem()
        {
            _cannotGetDbName = false;
            cb_DBName.Items.Clear();
            cb_DBName.Text = string.Empty;
            DisposeSqlHelper();
        }

        private void DisposeSqlHelper()
        {
            _sqlClientAdapter?.Dispose();
            _sqlClientAdapter = null;
        }

        private void LoadDbName()
        {
            if (_cannotGetDbName) return;
            if (cb_DBName.Items.Count > 0) return;
            txt_ServerName.Enabled = false;

            using (this.DisableWithWaitCursor())
            {
                try
                {
                    var items = SqlClientAdapter.GetDataBaseInfos().Select(d => d.Name).ToArray();
                    cb_DBName.Items.AddRange(items);
                }
                catch (Exception ex)
                {
                    this.ShowErrorMessage(ex);
                    _cannotGetDbName = true;
                }
                txt_ServerName.Enabled = true;
            }
        }

        private bool TestConnection(bool showMessage = true)
        {
            if (!ValidateChildren()) return false;

            using (this.DisableWithWaitCursor())
            {
                bool canConnect;
                try
                {
                    canConnect = SqlClientAdapter.Open();
                }
                catch (Exception ex)
                {
                    this.ShowErrorMessage(ex);
                    canConnect = false;
                }

                if (showMessage)
                    if (canConnect)
                        this.ShowInfoMessage("Test connection succeeded.");
                    else this.ShowErrorMessage("Cannot open the connection.");
                return canConnect;
            }
        }

        private void txt_ServerName_TextChanged(object sender, EventArgs e) => ClearDbNameItem();
    }
}