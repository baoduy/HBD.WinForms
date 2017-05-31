using HBD.Data.Comparisons;
using HBD.Framework;
using HBD.Framework.Exceptions;
using HBD.WinForms.Properties;
using System.ComponentModel;

namespace HBD.WinForms.Validation
{
    public class RangeValidatior : DataTypeValidatior
    {
        private string _maxValue;
        private string _minValue;

        public RangeValidatior(IContainer container) : base(container)
        {
        }

        public string MinValue
        {
            get { return _minValue; }
            set
            {
                if (_minValue == value) return;
                _minValue = value;
                OnPropertyChanged();
            }
        }

        public string MaxValue
        {
            get { return _maxValue; }
            set
            {
                if (_maxValue == value) return;
                _maxValue = value;
                OnPropertyChanged();
            }
        }

        protected override void UpdateDefaultErrorMessage()
            => DefaultErrorMessage = string.Format(Resources.Validation_RangeDefalutMessage, MinValue, MaxValue);

        protected override bool Validate(object value)
        {
            object minValue;
            object maxValue;

            if (!TryParse(MinValue, out minValue))
                throw new InvalidException(nameof(MinValue));

            if (MaxValue.IsNotNullOrEmpty())
                return value.CompareTo(CompareOperation.GreaterThanOrEquals, minValue);

            if (!TryParse(MaxValue, out maxValue))
                throw new InvalidException(nameof(MinValue));

            //if (minValue.IsGreaterThan(maxValue))
            //    throw new InvalidException(nameof(MinValue), nameof(MaxValue));

            return value.CompareTo(CompareOperation.GreaterThanOrEquals, minValue)
                   && value.CompareTo(CompareOperation.LessThanOrEquals, maxValue);
        }
    }
}