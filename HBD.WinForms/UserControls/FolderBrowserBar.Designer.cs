namespace HBD.WinForms.UserControls
{
    partial class FolderBrowserBar
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
            this.txt_Folder = new System.Windows.Forms.TextBox();
            this.btn_Browse = new HBD.WinForms.UserControls.FolderBrowserButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lb_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Folder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Browse, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.txt_Folder_DoubleClick);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Title.Location = new System.Drawing.Point(3, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(36, 30);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Folder";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Title.DoubleClick += new System.EventHandler(this.txt_Folder_DoubleClick);
            // 
            // txt_Folder
            // 
            this.txt_Folder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Folder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txt_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Folder.Location = new System.Drawing.Point(45, 5);
            this.txt_Folder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_Folder.Name = "txt_Folder";
            this.txt_Folder.Size = new System.Drawing.Size(331, 20);
            this.txt_Folder.TabIndex = 1;
            this.txt_Folder.DoubleClick += new System.EventHandler(this.txt_Folder_DoubleClick);
            this.txt_Folder.Leave += new System.EventHandler(this.txt_Folder_TextChanged);
            // 
            // btn_Browse
            // 
            this.btn_Browse.AutoSize = true;
            this.btn_Browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Browse.Location = new System.Drawing.Point(382, 3);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(52, 23);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Change += new System.EventHandler(this.btn_Browse_Change);
            // 
            // FolderBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FolderBrowserControl";
            this.Size = new System.Drawing.Size(437, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox txt_Folder;
        private FolderBrowserButton btn_Browse;
    }
}
