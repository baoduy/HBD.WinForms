namespace HBD.WinForms.UserControls
{
    partial class FileBrowserBar
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new HBD.WinForms.UserControls.FileBrowserButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_FilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Browse, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.txt_FilePath_DoubleClick);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Title.Location = new System.Drawing.Point(6, 0);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(47, 62);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "File";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Title.DoubleClick += new System.EventHandler(this.txt_FilePath_DoubleClick);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_FilePath.Location = new System.Drawing.Point(65, 10);
            this.txt_FilePath.Margin = new System.Windows.Forms.Padding(6, 10, 6, 6);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(554, 31);
            this.txt_FilePath.TabIndex = 1;
            this.txt_FilePath.DoubleClick += new System.EventHandler(this.txt_FilePath_DoubleClick);
            this.txt_FilePath.Leave += new System.EventHandler(this.txt_FilePath_Leave);
            // 
            // btn_Browse
            // 
            this.btn_Browse.AutoSize = true;
            this.btn_Browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Browse.Location = new System.Drawing.Point(631, 6);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(93, 35);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Change += new System.EventHandler(this.btn_Browse_Change);
            // 
            // FileBrowserBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FileBrowserBar";
            this.Size = new System.Drawing.Size(730, 62);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox txt_FilePath;
        private FileBrowserButton btn_Browse;
    }
}
