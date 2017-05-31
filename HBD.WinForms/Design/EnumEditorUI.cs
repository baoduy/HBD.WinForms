using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using HBD.Framework.Core;

namespace HBD.WinForms.Design
{
    [ToolboxItem(false)]
    public sealed partial class EnumEditorUI : UserControl
    {
        public EnumEditorUI(object editValue)
        {
            Guard.ArgumentIsNotNull(editValue, nameof(editValue));

            InitializeComponent();
            EditValue = editValue;
        }

        public object EditValue { get; private set; }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            // Get item value.
            var type = EditValue.GetType();
            var value = 0;

            for (var i = 1; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemCheckState(i) != CheckState.Checked) continue;

                var name = checkedListBox.Items[i] as string;
                var itemValue = (int) type.GetField(name).GetValue(EditValue);

                // Add item value.
                value |= itemValue;
            }

            EditValue = value;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var type = EditValue.GetType();
            // Gets all enumeration members.
            var fields = type.GetFields(BindingFlags.Static | BindingFlags.Public);

            //Add (None) Item
            checkedListBox.Items.Add("(None)", false);

            foreach (var field in fields)
            {
                // Add all enumeration members except none.
                var value = (int) field.GetValue(EditValue);
                if (value == 0) continue;

                // add current enumeration member and check it if value set bit of it.
                checkedListBox.Items.Add(field.Name, (value & (int) EditValue) == value);
            }

            Height = (checkedListBox.Items.Count + 2)*checkedListBox.GetItemHeight(0);
        }

        //private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.checkedListBox.BeginUpdate();

        //    if (this.checkedListBox.SelectedIndex == 0)
        //    {
        //        for (int i = 1; i < this.checkedListBox.Items.Count; i++)
        //            this.checkedListBox.SetItemChecked(i, false);
        //    }
        //    else this.checkedListBox.SetItemChecked(0, false);

        //    this.checkedListBox.EndUpdate();
        //}

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            #region Update status of check box

            checkedListBox.BeginUpdate();

            if (e.Index == 0)
                for (var i = 1; i < checkedListBox.Items.Count; i++)
                    checkedListBox.SetItemChecked(i, false);
            else checkedListBox.SetItemChecked(0, false);

            checkedListBox.EndUpdate();

            #endregion Update status of check box
        }
    }
}