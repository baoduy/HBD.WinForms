using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using HBD.Framework;
using HBD.Framework.Core;
using HBD.WinForms.Properties;

namespace HBD.WinForms.Validation
{
    public class DataTypeValidatior : BaseValidatior
    {
        private string[] _currecySymbols;
        private DataType _dataType = DataType.Integer;
        private string[] _dateFormates;

        public DataTypeValidatior(IContainer container) : base(container)
        {
            CurrecySymbols = CultureInfoHelper.GetCurrecySymbols();
        }

        [DefaultValue(DataType.Integer)]
        public DataType DataType
        {
            get { return _dataType; }
            set
            {
                if (_dataType == value) return;
                _dataType = value;
                OnPropertyChanged();
            }
        }

        public string[] CurrecySymbols
        {
            get
            {
                if (DataType != DataType.Currency) return null;
                return _currecySymbols;
            }
            set { _currecySymbols = value; }
        }

        public string[] DateFormats
        {
            get
            {
                if (DataType != DataType.DateTime) return null;
                return _dateFormates;
            }
            set { _dateFormates = value; }
        }

        protected bool TryParse(object value, out dynamic parsedValue)
        {
            parsedValue = null;

            if (value.IsNull()) return false;

            switch (DataType)
            {
                case DataType.Currency:
                {
                    if (value is decimal)
                    {
                        parsedValue = (decimal) value;
                        return true;
                    }

                    var str = value.ToString();
                    if (CurrecySymbols.Any(s => str.Count(s) > 1)) return false;

                    str = str.Remove(CurrecySymbols);
                    decimal tmp;
                    if (decimal.TryParse(str, out tmp))
                    {
                        parsedValue = tmp;
                        return true;
                    }
                }
                    break;

                case DataType.DateTime:
                {
                    if (value is DateTime)
                    {
                        parsedValue = (DateTime) value;
                        return true;
                    }

                    var str = value.ToString();
                    DateTime tmp;
                    if (TryParseDateTime(str, out tmp))
                    {
                        parsedValue = tmp;
                        return true;
                    }
                }
                    break;

                case DataType.Double:
                {
                    if (value is double)
                    {
                        parsedValue = (double) value;
                        return true;
                    }

                    var str = value.ToString();
                    double tmp;
                    if (double.TryParse(str, out tmp))
                    {
                        parsedValue = tmp;
                        return true;
                    }
                }
                    break;

                case DataType.Integer:
                {
                    if (value is int)
                    {
                        parsedValue = (int) value;
                        return true;
                    }

                    var str = value.ToString();
                    int tmp;
                    if (int.TryParse(str, out tmp))
                    {
                        parsedValue = tmp;
                        return true;
                    }
                }
                    break;

                case DataType.String:
                {
                    if (value is string)
                    {
                        parsedValue = value as string;
                        return true;
                    }
                }
                    break;
            }
            return false;
        }

        protected bool TryParseDateTime(string value, out DateTime date)
        {
            if (DateTime.TryParse(value, out date)) return true;
            return DateFormats.IsNotNull()
                   && DateTime.TryParseExact(value, DateFormats, null, DateTimeStyles.None, out date);
        }

        protected override void UpdateDefaultErrorMessage()
            => DefaultErrorMessage = string.Format(Resources.Validation_DataTypeDefaultMessage, DataType);

        protected override bool Validate(object value)
        {
            if (value.IsNull()) return true;
            dynamic tmp;
            return TryParse(value, out tmp);
        }
    }

    public enum DataType
    {
        Currency,
        DateTime,
        Double,
        Integer,
        String
    }
}