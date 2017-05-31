using HBD.Data.Comparisons;
using HBD.Data.Comparisons.Base;
using HBD.Framework.Core;
using System.Linq;
using System.Windows.Forms;

namespace HBD.WinForms.Utilities
{
    public class DataGridViewConditionValidation : ConditionValidation<DataGridViewRow>
    {
        private readonly DataGridView _dataGrid;

        public DataGridViewConditionValidation(DataGridView dataGrid)
        {
            Guard.ArgumentIsNotNull(dataGrid, nameof(dataGrid));
            _dataGrid = dataGrid;
        }

        public override void Validate(ICondition condition)
        {
            _dataGrid.ClearSelection();

            foreach (DataGridViewRow row in _dataGrid.Rows)
                row.Visible = IsSatisfy(row, condition);
        }

        protected override bool IsSatisfy(DataGridViewRow value, FieldCondition condition)
        {
            var leftValue = value.Cells[condition.Field].Value;
            var rightValue = value.Cells[condition.ConditionField].Value;

            return leftValue.CompareTo(condition.Operation, rightValue);
        }

        protected override bool IsSatisfy(DataGridViewRow value, ValueCondition condition)
            =>
            value.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value.CompareTo(condition.Operation, condition.Value));
    }
}