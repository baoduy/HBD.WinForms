using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;
using HBD.WinForms.Base;
using HBD.WinForms.Validation;

namespace HBD.WinForms.Design
{
    public sealed class ValidationTypeEditor : CollectionEditor
    {
        public ValidationTypeEditor(Type type) : base(type)
        {
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var list = new List<IValidation>();

            var cols = value as IValidation[];
            if ((cols != null) && (cols.Length > 0))
                list.AddRange(cols);

            base.EditValue(context, provider, list);
            return list.ToArray();
        }

        protected override object CreateInstance(Type itemType)
        {
            var instance = base.CreateInstance(itemType) as IValidation;
            instance.ValidationControl = (Control) Context.Instance;

            var count = Context.Container.Components.Cast<IComponent>().Count(c => c.GetType() == itemType);
            string name = $"{instance.ValidationControl.Name}_{itemType.Name}{count}";

            Context.Container.Add(instance, name);
            return instance;
        }

        protected override Type[] CreateNewItemTypes() => new[]
        {
            typeof(DataTypeValidatior),
            typeof(CompareValidatior),
            typeof(CheckboxCollectionValidator),
            typeof(RangeValidatior),
            typeof(RegularValidatior),
            typeof(RequiredValidatior),
            typeof(InExprectedListValidatior),
            typeof(CollectionCountValidator),
            typeof(CustomValidatior)
        };
    }
}