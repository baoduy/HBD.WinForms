using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HBD.Framework;
using HBD.Framework.Core;

namespace HBD.WinForms.Base
{
    public class DoubleDataSource<T> : INotifyPropertyChanged, IDisposable where T : class
    {
        private T _leftDataSource;

        private T _rightDataSource;

        public DoubleDataSource()
        {
        }

        public DoubleDataSource(T leftDataSource, T rightDataSource)
        {
            Guard.ArgumentIsNotNull(leftDataSource, nameof(leftDataSource));
            Guard.ArgumentIsNotNull(rightDataSource, nameof(rightDataSource));

            LeftDataSource = leftDataSource;
            RightDataSource = rightDataSource;
        }

        public T LeftDataSource
        {
            get { return _leftDataSource; }
            set
            {
                if (_leftDataSource == value) return;
                _leftDataSource = value;
                OnPropertyChanged();
            }
        }

        public T RightDataSource
        {
            get { return _rightDataSource; }
            set
            {
                if (_rightDataSource == value) return;
                _rightDataSource = value;
                OnPropertyChanged();
            }
        }

        public bool IsEmpty => LeftDataSource.IsNull() || RightDataSource.IsNull();

        public void Dispose()
        {
            (_leftDataSource as IDisposable)?.Dispose();
            (_rightDataSource as IDisposable)?.Dispose();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class DoubleDataSource : DoubleDataSource<object>
    {
        public DoubleDataSource()
        {
        }

        public DoubleDataSource(object leftDataSource, object rightDataSource) : base(leftDataSource, rightDataSource)
        {
        }
    }
}