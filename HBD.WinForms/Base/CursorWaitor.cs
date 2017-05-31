using System;
using System.Windows.Forms;

namespace HBD.WinForms.Base
{
    public class DisabledWithCursorWaitor<T> : CursorWaitor where T : ContainerControl
    {
        private readonly T _instance;

        public DisabledWithCursorWaitor(T instance)
        {
            _instance = instance;
            _instance.Enabled = false;
        }

        public override void Dispose()
        {
            base.Dispose();
            _instance.Enabled = true;
        }
    }

    //public class CursorWaitor<T> : CursorWaitor where T : IDisposable
    //{
    //    public T Instance { get; }

    //    public CursorWaitor(T disposable) { Instance = disposable; }

    //    public override void Dispose()
    //    {
    //        base.Dispose();
    //        Instance?.Dispose();
    //    }
    //}

    public class CursorWaitor : IDisposable
    {
        public CursorWaitor()
        {
            Application.UseWaitCursor = true;
            Application.DoEvents();
        }

        public virtual void Dispose()
        {
            Application.UseWaitCursor = false;
            Application.DoEvents();
        }
    }
}