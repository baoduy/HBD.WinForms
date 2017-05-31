using HBD.Data.Comparisons;
using HBD.Framework;
using HBD.WinForms.Exceptions;
using HBD.WinForms.Properties;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace HBD.WinForms.Validation
{
    public class CollectionCountValidator : BaseValidatior
    {
        private int _expectedCountAmount;
        private CompareOperation _operation = CompareOperation.Equals;

        public CollectionCountValidator(IContainer container) : base(container)
        {
        }

        [DefaultValue(CompareOperation.Equals)]
        public CompareOperation Operation
        {
            get { return _operation; }
            set
            {
                if (_operation == value) return;
                _operation = value;
                OnPropertyChanged();
            }
        }

        [DefaultValue(0)]
        public int ExpectedCountAmount
        {
            get { return _expectedCountAmount; }
            set
            {
                if ((_expectedCountAmount == value) || (value < 0)) return;
                _expectedCountAmount = value;
                OnPropertyChanged();
            }
        }

        protected override void UpdateDefaultErrorMessage()
            =>
            DefaultErrorMessage =
                string.Format(Resources.Validation_CollectionCountDefaultMessage, Operation, ExpectedCountAmount);

        protected override bool Validate(object value)
        {
            if (value == null) return true;
            if (!(value is IEnumerable)) throw new ValidationException("Value must be a collection.");

            return ((IEnumerable)value).Cast<object>().Count().CompareTo(Operation, ExpectedCountAmount);
        }
    }
}