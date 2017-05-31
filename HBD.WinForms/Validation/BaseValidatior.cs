using HBD.Framework;
using HBD.Framework.Core;
using HBD.WinForms.Base;
using HBD.WinForms.Design;
using HBD.WinForms.Properties;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HBD.WinForms.Validation
{
    [ToolboxItem(false)]
    public class BaseValidatior : Component, IValidation, INotifyPropertyChanged
    {
        private string _errorMessage;

        private Control _validationControl;

        protected BaseValidatior(IContainer container)
        {
            container.Add(this);
        }

        public string DefaultErrorMessage { get; protected set; }

        [Editor(typeof(PropertiesSelectionTypeEditor), typeof(UITypeEditor))]
        public string ValidationProperty { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [DefaultValue(null)]
        public Control ValidationControl
        {
            get { return _validationControl; }
            set
            {
                if (_validationControl == value) return;
                _validationControl = value;
                if (_validationControl != null)
                    ValidationProperty = _validationControl.GetDefaultPropertyName();
            }
        }

        /// <summary>
        /// The control that error message indicator will be displayed.
        /// </summary>
        [DefaultValue(null)]
        public Control DisplayErrorControl { get; set; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(true)]
        public virtual bool Enabled { get; set; } = true;

        /// <summary>
        /// Show error pop-up dialog instead if error icon at the side of control.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public virtual bool ShowErrorMessgeDialog { get; set; } = false;

        [DefaultValue(null)]
        public string ErrorMessage
        {
            get
            {
                return _errorMessage.IsNullOrEmpty()
                    ? DefaultErrorMessage
                    : _errorMessage;
            }
            set { _errorMessage = value; }
        }

        public virtual bool Validate()
        {
            if (!Enabled) return true;
            if ((ValidationControl == null) || ValidationProperty.IsNullOrEmpty()) return false;
            return Validate(ValidationControl);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            UpdateDefaultErrorMessage();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void UpdateDefaultErrorMessage()
            => DefaultErrorMessage = Resources.Validate_InvalidMessage;

        protected bool Validate(Control control)
        {
            Guard.ArgumentIsNotNull(control, nameof(control));
            var value = control.GetValueFromProperty(ValidationProperty);
            return Validate(value);
        }

        protected virtual bool Validate(object value) => true;
    }
}