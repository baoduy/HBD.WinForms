using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    public abstract class BaseDoubleDataSourceControl<T> : UserControl where T : class
    {
        private DoubleDataSource<T> _dataSource;

        protected BaseDoubleDataSourceControl()
        {
            if (DataSource != null) return;

            DataSource = new DoubleDataSource<T>();
        }

        [DefaultValue(null)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DoubleDataSource<T> DataSource
        {
            get { return _dataSource; }
            set
            {
                if (_dataSource == value) return;

                if (_dataSource != null)
                    _dataSource.PropertyChanged -= DataSource_PropertyChanged;

                _dataSource = value;
                OnDataSourceChanged(new PropertyChangedEventArgs(nameof(DataSource)));

                if (_dataSource != null)
                    _dataSource.PropertyChanged += DataSource_PropertyChanged;
            }
        }

        public event EventHandler<PropertyChangedEventArgs> DataSourceChanged;

        protected virtual void OnDataSourceChanged(PropertyChangedEventArgs e) => DataSourceChanged?.Invoke(this, e);

        private void DataSource_PropertyChanged(object sender, PropertyChangedEventArgs e) => OnDataSourceChanged(e);
    }

    public class DoubleDataSourceControlBase : BaseDoubleDataSourceControl<object>
    {
    }
}