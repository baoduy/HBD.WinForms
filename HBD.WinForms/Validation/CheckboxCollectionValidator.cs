using HBD.Data.Comparisons;
using HBD.Framework;
using HBD.WinForms.Properties;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.Validation
{
    /// <summary>
    /// This validation for GroupBox (CheckBox and RadioButton), CheckedListBox, ListView and TreeView
    /// </summary>
    public class CheckboxCollectionValidator : CollectionCountValidator
    {
        public CheckboxCollectionValidator(IContainer container) : base(container)
        {
        }

        public override bool Validate()
        {
            if (ValidationControl is GroupBox)
            {
                var checkboxItems = ValidationControl.Controls.OfType<CheckBox>().ToArray();
                if (!checkboxItems.IsNull())
                    return checkboxItems.Count(i => i.Checked).CompareTo(Operation, ExpectedCountAmount);

                var radioItems = ValidationControl.Controls.OfType<RadioButton>().ToArray();
                if (!radioItems.IsNull())
                    return radioItems.Count(i => i.Checked).CompareTo(Operation, ExpectedCountAmount);
            }
            else if (ValidationControl is CheckedListBox)
            {
                var list = (CheckedListBox)ValidationControl;
                return list.CheckedItems.Count.CompareTo(Operation, ExpectedCountAmount);
            }
            else if (ValidationControl is ListView)
            {
                var list = (ListView)ValidationControl;
                return list.CheckedItems.Count.CompareTo(Operation, ExpectedCountAmount);
            }
            else if (ValidationControl is TreeView)
            {
                var tree = (TreeView)ValidationControl;
                return tree.Nodes
                    .Descendants()
                    .Count(t => t.Checked)
                    .CompareTo(Operation, ExpectedCountAmount);
            }
            else return ValidationUnSupportedControl();

            return false;
        }

        protected override void UpdateDefaultErrorMessage()
            => DefaultErrorMessage = string.Format(Resources.Validation_CheckboxCollectionDefaultMessage, Operation,
                ExpectedCountAmount);

        protected virtual bool ValidationUnSupportedControl()
        {
            throw new NotSupportedException(
                $"{ValidationControl.GetType().Name} is not supported by this validation. Inherit this validator and override ValidationUnSupportedControl() method to extend the validation.");
        }
    }
}