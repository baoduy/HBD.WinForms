namespace HBD.WinForms.UserControls
{
    partial class FilterItem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Ope = new System.Windows.Forms.ComboBox();
            this.cb_Field = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.cb_Ope, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Field, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cb_Ope
            // 
            this.cb_Ope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ope.FormattingEnabled = true;
            this.cb_Ope.Location = new System.Drawing.Point(183, 3);
            this.cb_Ope.Name = "cb_Ope";
            this.cb_Ope.Size = new System.Drawing.Size(175, 21);
            this.cb_Ope.TabIndex = 1;
            this.cb_Ope.SelectedIndexChanged += new System.EventHandler(this.cb_Ope_SelectedIndexChanged);
            // 
            // cb_Field
            // 
            this.cb_Field.DisplayMember = "ColumnName";
            this.cb_Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Field.FormattingEnabled = true;
            this.cb_Field.Location = new System.Drawing.Point(3, 3);
            this.cb_Field.Name = "cb_Field";
            this.cb_Field.Size = new System.Drawing.Size(174, 21);
            this.cb_Field.TabIndex = 0;
            this.cb_Field.SelectedIndexChanged += new System.EventHandler(this.cb_Field_SelectedIndexChanged);
            // 
            // FilterItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterItem";
            this.Size = new System.Drawing.Size(555, 26);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_Field;
        private System.Windows.Forms.ComboBox cb_Ope;
    }
}
