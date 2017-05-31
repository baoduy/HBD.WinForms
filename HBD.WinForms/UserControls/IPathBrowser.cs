using System;
using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    public interface IPathBrowser
    {
        string SelectedPath { get; set; }

        event EventHandler Change;

        DialogResult OpenDialog();
    }
}