namespace HBD.WinForms.UserControls
{
    partial class DataGridViewSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewSearch));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new HBD.WinForms.UserControls.SearchTextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Back
            // 
            this.bt_Back.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Back.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Back.Image = global::HBD.WinForms.Properties.Resources.back;
            this.bt_Back.Location = new System.Drawing.Point(254, 3);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(22, 22);
            this.bt_Back.TabIndex = 1;
            this.bt_Back.TabStop = false;
            this.toolTip.SetToolTip(this.bt_Back, "Start search");
            this.bt_Back.UseVisualStyleBackColor = false;
            this.bt_Back.Visible = false;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Next.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Next.Image = global::HBD.WinForms.Properties.Resources.forward;
            this.bt_Next.Location = new System.Drawing.Point(282, 3);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(22, 22);
            this.bt_Next.TabIndex = 2;
            this.bt_Next.TabStop = false;
            this.toolTip.SetToolTip(this.bt_Next, "Start search");
            this.bt_Next.UseVisualStyleBackColor = false;
            this.bt_Next.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.bt_Next, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.bt_Back, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.searchTextBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(307, 26);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoClick = true;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.CancelImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.CancelImage")));
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.SearchImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.SearchImage")));
            this.searchTextBox.Size = new System.Drawing.Size(245, 22);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // DataGridViewSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DataGridViewSearchControl";
            this.Size = new System.Drawing.Size(307, 26);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private SearchTextBox searchTextBox;
    }
}
