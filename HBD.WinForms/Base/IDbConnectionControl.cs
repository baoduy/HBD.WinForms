using System;

namespace HBD.WinForms.Base
{
    public interface IDbConnectionControl
    {
        string ConnectionString { get; set; }

        event EventHandler Changed;
    }
}