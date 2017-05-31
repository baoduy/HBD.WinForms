using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using HBD.Framework;
using HBD.WinForms.Attributes;
using HBD.WinForms.Base;
using HBD.WinForms.Design;

namespace HBD.WinForms.Validation
{
    [ProvideProperty("Validators", typeof(Control))]
    [ToolboxItemFilter("System.Windows.Forms")]
    [ToolboxBitmap("Resources.Validation.ico")]
    public partial class ValidationManager : Component, IExtenderProvider, ISupportInitialize
    {
        private readonly IContainer _container;

        private readonly IDictionary<Control, IValidation[]> _enabledControls =
            new Dictionary<Control, IValidation[]>();

        private bool _isInitializing;

        public ValidationManager(IContainer container)
        {
            if (container.Components.OfType<ValidationManager>().Any())
                throw new NotSupportedException("ValidationManager is already existed.");

            _container = container;
            container.Add(this);
            InitializeComponent();
        }

        public ContainerControl ContainerControl {
            [UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)] [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)] get; set; }

        public override ISite Site
        {
            set
            {
                base.Site = value;

                if (value == null)
                {
                    //Remove all associated validators when delete Validation Manager.
                    foreach (var v in _enabledControls.SelectMany(c => c.Value))
                        _container.Remove(v);
                    return;
                }

                //Find the Container Control
                var designerHost = value?.GetService(typeof(IDesignerHost)) as IDesignerHost;
                var rootComponent = designerHost?.RootComponent;
                if (!(rootComponent is ContainerControl)) return;
                ContainerControl = (ContainerControl) rootComponent;
            }
        }

        /// <summary>
        ///     The Icon will be display when control is invalid.
        /// </summary>
        [Localizable(true)]
        public Icon Icon
        {
            get { return errorProvider.Icon; }
            set { errorProvider.Icon = value; }
        }

        [DefaultValue(true)]
        public virtual bool Enabled { get; set; } = true;

        [DefaultValue(ValidationCondition.EventPerControl)]
        public ValidationCondition ValidationCondition { get; set; } = ValidationCondition.EventPerControl;

        public bool CanExtend(object extendee) =>
            !(extendee is Form)
            && !(extendee is IButtonControl)
            && !extendee.GetType().GetCustomAttributes(typeof( NotAllowValidationAttribute ), true).Any()
            && extendee is Control
            && Enabled;

        public virtual void BeginInit()
        {
            _isInitializing = true;

            switch (ValidationCondition)
            {
                case ValidationCondition.EventPerControl:
                {
                    foreach (var control in _enabledControls)
                        control.Key.Validating -= Control_Validating;
                }
                    break;
                //case ValidationCondition.EventOnContainer:
                //    if (ContainerControl != null)
                //    {
                //        this.ContainerControl.Validating -= ContainerControl_Validating;
                //        this.ContainerControl.EnabledChanged -= ContainerControl_EnabledChanged;
                //    }
                //    break;
            }
        }

        public virtual void EndInit()
        {
            switch (ValidationCondition)
            {
                case ValidationCondition.EventPerControl:
                {
                    foreach (var control in _enabledControls)
                        control.Key.Validating += Control_Validating;
                }
                    break;
                //case ValidationCondition.EventOnContainer:
                //    if (ContainerControl != null)
                //    {
                //        this.ContainerControl.CausesValidation = true;
                //        this.ContainerControl.Validating += ContainerControl_Validating;
                //        this.ContainerControl.EnabledChanged += ContainerControl_EnabledChanged;
                //    }
                //    break;
            }

            _isInitializing = false;
        }

        /// <summary>
        ///     Manual Validate.
        /// </summary>
        /// <returns></returns>
        public virtual bool Validate()
        {
            if (Enabled && !_isInitializing)
                return _enabledControls.All(c => Validate(c.Key));

            errorProvider.Clear();
            return true;
        }

        private void ContainerControl_EnabledChanged(object sender, EventArgs e)
        {
            if (!((Control) sender).Enabled) errorProvider.Clear();
        }

        //private void ContainerControl_Validating(object sender, CancelEventArgs e) => e.Cancel = this.Validate();
        private void Control_Validating(object sender, CancelEventArgs e) => e.Cancel = !Validate((Control) sender);

        private bool Validate(Control control)
        {
            if (!Enabled || DesignMode)
            {
                errorProvider.Clear();
                return true;
            }

            //Don't validate Disabled o Invisible controls
            if (!control.Enabled || !control.Visible) return true;
            var validations = _enabledControls[control];

            foreach (var va in validations.Where(va => va.Enabled))
                if (va.Validate())
                    errorProvider.SetError(va.DisplayErrorControl ?? va.ValidationControl, null);
                else
                {
                    if (va.ShowErrorMessgeDialog)
                        this.ShowErrorMessage(va.ErrorMessage);
                    else errorProvider.SetError(va.DisplayErrorControl ?? va.ValidationControl, va.ErrorMessage);
                    return false;
                }
            return true;
        }

        #region Gets Sets validation type

        [DefaultValue(null)]
        [ResourceableCategory("Validation_Category")]
        [ResourceableDescription("Validation_Type_Description")]
        [Localizable(true)]
        [Editor(typeof(ValidationTypeEditor), typeof(UITypeEditor))]
        public virtual void SetValidators(Control control, params IValidation[] validation)
        {
            if (DesignMode && ((control == null) || control.GetType().GetCustomAttributes(typeof(NotAllowValidationAttribute), true).Any())) return;

            var vals = validation?.Where(a => a != null).ToArray();

            if (((vals == null) || (vals.Length == 0))
                && _enabledControls.ContainsKey(control))
                _enabledControls.Remove(control);
            else
            {
                foreach (var val in vals)
                    val.ValidationControl = control;

                _enabledControls[control] = vals;

                //if (ValidationCondition == ValidationCondition.EventPerControl)
                //    control.Validating += Control_Validating;
            }
        }

        [DefaultValue(null)]
        [ResourceableCategory("Validation_Category")]
        [ResourceableDescription("Validation_Type_Description")]
        [Localizable(true)]
        [Editor(typeof(ValidationTypeEditor), typeof(UITypeEditor))]
        public virtual IValidation[] GetValidators(Control control)
            => _enabledControls.ContainsKey(control) ? _enabledControls[control] : null;

        #endregion Gets Sets validation type
    }

    /// <summary>
    /// </summary>
    public enum ValidationCondition
    {
        EventPerControl = 0,

        //EventOnContainer = 1,
        Manual = 2
    }
}