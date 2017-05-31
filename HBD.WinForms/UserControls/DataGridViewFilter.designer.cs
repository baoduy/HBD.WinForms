using System.Windows.Forms;

namespace HBD.WinForms.UserControls
{
    partial class DataGridViewFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_MatchAnyRule = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Filter = new System.Windows.Forms.Button();
            this.filterCollection = new ListControlCollection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_MatchAnyRule);
            this.groupBox1.Controls.Add(this.bt_Filter);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(751, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ch_MatchAnyRule
            // 
            this.ch_MatchAnyRule.AutoSize = true;
            this.ch_MatchAnyRule.Dock = System.Windows.Forms.DockStyle.Left;
            this.ch_MatchAnyRule.Location = new System.Drawing.Point(6, 13);
            this.ch_MatchAnyRule.Name = "ch_MatchAnyRule";
            this.ch_MatchAnyRule.Size = new System.Drawing.Size(146, 24);
            this.ch_MatchAnyRule.TabIndex = 0;
            this.ch_MatchAnyRule.Text = "Match any of rules above";
            this.ch_MatchAnyRule.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(673, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Filter
            // 
            this.bt_Filter.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Filter.Location = new System.Drawing.Point(588, 13);
            this.bt_Filter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(75, 24);
            this.bt_Filter.TabIndex = 1;
            this.bt_Filter.Text = "Done";
            this.bt_Filter.UseVisualStyleBackColor = true;
            this.bt_Filter.Click += new System.EventHandler(this.bt_Filter_Click);
            // 
            // filterCollection
            // 
            this.filterCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterCollection.Location = new System.Drawing.Point(0, 0);
            this.filterCollection.Name = "filterCollection";
            this.filterCollection.Size = new System.Drawing.Size(751, 256);
            this.filterCollection.TabIndex = 0;
            this.filterCollection.ControlAdded += new ControlEventHandler(this.filterCollection_ChildrenControlAdded);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(663, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 24);
            this.panel1.TabIndex = 3;
            // 
            // DataGridViewFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterCollection);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataGridViewFilterControl";
            this.Size = new System.Drawing.Size(751, 296);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Filter;
        private ListControlCollection filterCollection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ch_MatchAnyRule;
        private System.Windows.Forms.Panel panel1;
    }
}
