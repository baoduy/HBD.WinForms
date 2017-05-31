using System;
using System.Windows.Forms;

namespace HBD.WinForms.EventArguments
{
    public class DataGridSelectionChangedEventArgs : EventArgs
    {
        public DataGridSelectionChangedEventArgs(DataGridView grid)
        {
            Grid = grid;
        }

        public DataGridView Grid { get; private set; }
    }
}