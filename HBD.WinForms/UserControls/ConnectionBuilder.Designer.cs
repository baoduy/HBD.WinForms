namespace HBD.WinForms.UserControls
{
    partial class ConnectionBuilder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Title = new System.Windows.Forms.Label();
            this.txt_ConnectionString = new System.Windows.Forms.TextBox();
            this.btn_NewOrUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ContextMenuStrip = this.contextMenuStrip;
            this.tableLayoutPanel1.Controls.Add(this.lb_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ConnectionString, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_NewOrUpdate, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(145, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.ContextMenuStrip = this.contextMenuStrip;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Title.Location = new System.Drawing.Point(3, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(91, 30);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Connection String";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ConnectionString
            // 
            this.txt_ConnectionString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_ConnectionString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_ConnectionString.ContextMenuStrip = this.contextMenuStrip;
            this.txt_ConnectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ConnectionString.Location = new System.Drawing.Point(100, 5);
            this.txt_ConnectionString.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_ConnectionString.Name = "txt_ConnectionString";
            this.txt_ConnectionString.ReadOnly = true;
            this.txt_ConnectionString.Size = new System.Drawing.Size(271, 20);
            this.txt_ConnectionString.TabIndex = 0;
            this.txt_ConnectionString.TextChanged += new System.EventHandler(this.txt_ConnectionString_TextChanged);
            // 
            // btn_NewOrUpdate
            // 
            this.btn_NewOrUpdate.AutoSize = true;
            this.btn_NewOrUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_NewOrUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NewOrUpdate.Location = new System.Drawing.Point(377, 3);
            this.btn_NewOrUpdate.Name = "btn_NewOrUpdate";
            this.btn_NewOrUpdate.Size = new System.Drawing.Size(73, 24);
            this.btn_NewOrUpdate.TabIndex = 1;
            this.btn_NewOrUpdate.Text = "Create New";
            this.btn_NewOrUpdate.UseVisualStyleBackColor = true;
            this.btn_NewOrUpdate.Click += new System.EventHandler(this.btn_NewOrUpdate_Click);
            // 
            // ConnectionBuilderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConnectionBuilderControl";
            this.Size = new System.Drawing.Size(453, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox txt_ConnectionString;
        private System.Windows.Forms.Button btn_NewOrUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}
