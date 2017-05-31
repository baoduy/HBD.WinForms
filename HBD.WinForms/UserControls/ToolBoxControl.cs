using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace HBD.WinForms.UserControls
{
    public partial class ToolBoxControl : UserControl
    {
        private IList<Type> _dataSource;

        public ToolBoxControl()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Type> DataSource
        {
            get => _dataSource;

            set
            {
                if (Equals(_dataSource, value)) return;
                _dataSource = value;
                OnDataSourceChanged(EventArgs.Empty);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Type SelectedItem { get; set; }

        public event EventHandler DataSourceChanged;

        protected virtual void OnDataSourceChanged(EventArgs e)
        {
            treeView.Nodes.Clear();

            foreach (var type in DataSource)
            {
                var name = type.Name;

                if (!imageList.Images.ContainsKey(name))
                {
                    var att = type.GetCustomAttributes<ToolboxBitmapAttribute>().FirstOrDefault() ?? new ToolboxBitmapAttribute(type);
                    imageList.Images.Add(name, att.GetImage(type, true));
                }

                treeView.Nodes.Add(name, name, name, name);
            }

            if (SelectedItem != null)
                treeView.SelectedNode = treeView.Nodes.Find(SelectedItem.Name, false).FirstOrDefault();

            DataSourceChanged?.Invoke(this, e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            treeView.Focus();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
            => SelectedItem = DataSource.FirstOrDefault(t => t.Name == e.Node.Name);
    }
}