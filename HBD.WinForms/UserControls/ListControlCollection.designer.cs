namespace HBD.WinForms.UserControls
{
    partial class ListControlCollection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableColumns = new System.Windows.Forms.TableLayoutPanel();
            this.bt_AddRemove = new HBD.WinForms.UserControls.AddRemoveButton();
            this.controlTemplatePanel = new HBD.WinForms.UserControls.ControlTemplatePanel();
            this.tableColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableColumns
            // 
            this.tableColumns.AutoSize = true;
            this.tableColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableColumns.ColumnCount = 3;
            this.tableColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableColumns.Controls.Add(this.bt_AddRemove, 2, 0);
            this.tableColumns.Controls.Add(this.controlTemplatePanel, 0, 0);
            this.tableColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableColumns.Location = new System.Drawing.Point(0, 0);
            this.tableColumns.Name = "tableColumns";
            this.tableColumns.RowCount = 1;
            this.tableColumns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableColumns.Size = new System.Drawing.Size(409, 197);
            this.tableColumns.TabIndex = 2;
            // 
            // bt_AddRemove
            // 
            this.bt_AddRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_AddRemove.ImageList = null;
            this.bt_AddRemove.Location = new System.Drawing.Point(356, 3);
            this.bt_AddRemove.MinimumSize = new System.Drawing.Size(50, 15);
            this.bt_AddRemove.Name = "bt_AddRemove";
            this.bt_AddRemove.Size = new System.Drawing.Size(50, 25);
            this.bt_AddRemove.TabIndex = 0;
            this.bt_AddRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_AddRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // controlTemplatePanel
            // 
            this.controlTemplatePanel.Name = "controlTemplatePanel";
            this.controlTemplatePanel.Padding = new System.Windows.Forms.Padding(3);
            // 
            // ListControlCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableColumns);
            this.Name = "ListControlCollection";
            this.Size = new System.Drawing.Size(409, 197);
            // 
            // 
            // 
            this.WorkingArea.Location = new System.Drawing.Point(0, 0);
            this.WorkingArea.Name = "";
            this.WorkingArea.TabIndex = 0;
            this.tableColumns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableColumns;
        private AddRemoveButton bt_AddRemove;
        private ControlTemplatePanel controlTemplatePanel;
    }
}
