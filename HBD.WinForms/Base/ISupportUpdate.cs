namespace HBD.WinForms.Base
{
    public interface ISupportUpdate
    {
        bool IsUpdating { get; }

        void BeginUpdate();

        void EndUpdate();
    }
}