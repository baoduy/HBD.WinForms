namespace HBD.WinForms.TestApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddRemoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SqlQueryBuilderDialog = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddRemoveButton
            // 
            this.btn_AddRemoveButton.AutoSize = true;
            this.btn_AddRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddRemoveButton.Location = new System.Drawing.Point(3, 3);
            this.btn_AddRemoveButton.Name = "btn_AddRemoveButton";
            this.btn_AddRemoveButton.Size = new System.Drawing.Size(144, 23);
            this.btn_AddRemoveButton.TabIndex = 0;
            this.btn_AddRemoveButton.Text = "Test Add/Remove Buttons";
            this.btn_AddRemoveButton.UseVisualStyleBackColor = true;
            this.btn_AddRemoveButton.Click += new System.EventHandler(this.btn_AddRemoveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_AddRemoveButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_SqlQueryBuilderDialog, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 658);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_SqlQueryBuilderDialog
            // 
            this.btn_SqlQueryBuilderDialog.AutoSize = true;
            this.btn_SqlQueryBuilderDialog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SqlQueryBuilderDialog.Location = new System.Drawing.Point(3, 32);
            this.btn_SqlQueryBuilderDialog.Name = "btn_SqlQueryBuilderDialog";
            this.btn_SqlQueryBuilderDialog.Size = new System.Drawing.Size(144, 23);
            this.btn_SqlQueryBuilderDialog.TabIndex = 1;
            this.btn_SqlQueryBuilderDialog.Text = "Test Sql Query Builder";
            this.btn_SqlQueryBuilderDialog.UseVisualStyleBackColor = true;
            this.btn_SqlQueryBuilderDialog.Click += new System.EventHandler(this.btn_SqlQueryBuilderDialog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 658);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddRemoveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_SqlQueryBuilderDialog;
    }
}