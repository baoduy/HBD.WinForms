using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using HBD.WinForms.Attributes;
using HBD.WinForms.Base;

namespace HBD.WinForms.UserControls
{
    [DefaultEvent("Click")]
    [DefaultProperty("ListControl")]
    [NotAllowValidation]
    [ToolboxBitmap(typeof(Button))]
    public sealed partial class AddRemoveButton : UserControl, IAddRemoveButton
    {
        public AddRemoveButton()
        {
            InitializeComponent();
        }

        public new event EventHandler<AddRemoveButtonEventArgs> Click;

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            bt_Add.BackColor = BackColor;
            bt_Remove.BackColor = BackColor;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            control_ChildrenControlAddedRemoved(this, null);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            ListControl?.AddNewControl();
            OnClick(new AddRemoveButtonEventArgs(AddRemoveButtonAction.Add));
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            ListControl?.RemoveControl();
            OnClick(new AddRemoveButtonEventArgs(AddRemoveButtonAction.Remove));
        }

        private void OnClick(AddRemoveButtonEventArgs e) => Click?.Invoke(this, e);

        #region Button Properties

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoEllipsis
        {
            get { return bt_Add.AutoEllipsis; }
            set
            {
                bt_Add.AutoEllipsis = value;
                bt_Remove.AutoEllipsis = value;
            }
        }

        [Localizable(true)]
        [DefaultValue(FlatStyle.Standard)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FlatStyle FlatStyle
        {
            get { return bt_Add.FlatStyle; }
            set
            {
                bt_Add.FlatStyle = value;
                bt_Remove.FlatStyle = value;
            }
        }

        [Localizable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ContentAlignment ImageAlign
        {
            get { return bt_Add.ImageAlign; }
            set
            {
                bt_Add.ImageAlign = value;
                bt_Remove.ImageAlign = value;
            }
        }

        [Localizable(true)]
        [DefaultValue("")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image AddImage
        {
            get { return bt_Add.Image; }
            set { bt_Add.Image = value; }
        }

        [Localizable(true)]
        [DefaultValue("")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image RemoveImage
        {
            get { return bt_Remove.Image; }
            set { bt_Remove.Image = value; }
        }

        [TypeConverter(typeof(ImageIndexConverter))]
        [Editor(
             "System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             typeof(UITypeEditor))]
        [Localizable(true)]
        [DefaultValue(-1)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public int AddImageIndex
        {
            get { return bt_Add.ImageIndex; }
            set { bt_Add.ImageIndex = value; }
        }

        [TypeConverter(typeof(ImageKeyConverter))]
        [Localizable(true)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [DefaultValue("")]
        [Editor(
             "System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             typeof(UITypeEditor))]
        public string AddImageKey
        {
            get { return bt_Add.ImageKey; }
            set { bt_Add.ImageKey = value; }
        }

        [TypeConverter(typeof(ImageIndexConverter))]
        [Editor(
             "System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             typeof(UITypeEditor))]
        [Localizable(true)]
        [DefaultValue(-1)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public int RemoveImageIndex
        {
            get { return bt_Remove.ImageIndex; }
            set { bt_Remove.ImageIndex = value; }
        }

        [TypeConverter(typeof(ImageKeyConverter))]
        [Localizable(true)]
        [DefaultValue("")]
        [RefreshProperties(RefreshProperties.Repaint)]
        [Editor(
             "System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             typeof(UITypeEditor))]
        public string RemoveImageKey
        {
            get { return bt_Remove.ImageKey; }
            set { bt_Remove.ImageKey = value; }
        }

        [RefreshProperties(RefreshProperties.Repaint)]
        [DefaultValue("")]
        public ImageList ImageList
        {
            get { return bt_Add.ImageList; }
            set
            {
                bt_Add.ImageList = value;
                bt_Remove.ImageList = value;
            }
        }

        [Editor(
             "System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             typeof(UITypeEditor))]
        [SettingsBindable(true)]
        [DefaultValue("+")]
        public string AddText
        {
            get { return bt_Add.Text; }
            set { bt_Add.Text = value; }
        }

        [Editor(
             "System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
             typeof(UITypeEditor))]
        [SettingsBindable(true)]
        [DefaultValue("-")]
        public string RemoveText
        {
            get { return bt_Remove.Text; }
            set { bt_Remove.Text = value; }
        }

        [Localizable(true)]
        public ContentAlignment TextAlign
        {
            get { return bt_Add.TextAlign; }
            set
            {
                bt_Add.TextAlign = value;
                bt_Remove.TextAlign = value;
            }
        }

        [Localizable(true)]
        public TextImageRelation TextImageRelation
        {
            get { return bt_Add.TextImageRelation; }
            set
            {
                bt_Add.TextImageRelation = value;
                bt_Remove.TextImageRelation = value;
            }
        }

        #endregion Button Properties

        #region Others Properties

        private IListControlCollection _listControl;

        [DefaultValue(null)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public IListControlCollection ListControl
        {
            get { return _listControl; }
            set
            {
                if (_listControl == value) return;
                if (_listControl != null)
                {
                    _listControl.ControlAdded -= control_ChildrenControlAddedRemoved;
                    _listControl.ControlRemoved -= control_ChildrenControlAddedRemoved;
                }

                _listControl = value;
                _listControl.ControlAdded += control_ChildrenControlAddedRemoved;
                _listControl.ControlRemoved += control_ChildrenControlAddedRemoved;
            }
        }

        private void control_ChildrenControlAddedRemoved(object sender, ControlEventArgs e)
        {
            if (ListControl == null)
            {
                Enabled = false;
                return;
            }

            bt_Remove.Enabled = ListControl.ChildrenControls.Count > 0;
            if (ListControl.MaxChildrenControl > 0)
                bt_Add.Enabled = ListControl.ChildrenControls.Count < ListControl.MaxChildrenControl;
            else bt_Add.Enabled = true;
        }

        #endregion Others Properties
    }

    public class AddRemoveButtonEventArgs : EventArgs
    {
        public AddRemoveButtonEventArgs(AddRemoveButtonAction buttonType)
        {
            ButtonType = buttonType;
        }

        public AddRemoveButtonAction ButtonType { get; private set; }
    }

    public enum AddRemoveButtonAction
    {
        Add,
        Remove
    }
}