using HBD.Framework;
using HBD.Framework.Core;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.Utilities
{
    public class DataGridViewSearchManager : SearchManagerBase<DataGridView, DataGridViewCell>
    {
        public DataGridViewSearchManager(DataGridView grid) : base(grid)
        {
        }

        public override object CurrentItemValue => CurrentItem?.Value;

        protected override void ClearHighLightItem(DataGridViewCell cell) => cell.Style.BackColor = Color.Empty;

        protected override void DoSearch()
        {
            //Start new thread
            CurrentThread = BackgroundThreadHelper.StartThread(() =>
            {
                lock (Locker)
                {
                    try
                    {
                        foreach (var row in Control.Rows.Cast<DataGridViewRow>().Where(row => row.Visible))
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                var val = cell.Value;
                                if (val?.ToString().ContainsIgnoreCase(Keyword) == true)
                                    AddResult(cell);

                                //Break the cell loop
                                if (StopSearching) break;
                            }

                            //Break the row loop
                            if (StopSearching) break;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        Status = SearchStatus.Completed;
                    }
                } //End lock
            });
        }

        protected override void HighLightItem(DataGridViewCell cell) => cell.Style.BackColor = Color.Yellow;

        protected override bool SetFocusToItem(DataGridViewCell item)
        {
            if (!item.Visible) return false;

            try
            {
                Control.CurrentCell = item;
                return true;
            }
            catch
            {
                Reset();
                return false;
            }
        }
    }
}