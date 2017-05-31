namespace HBD.WinForms.TestApp
{
    partial class AddRemoveButtonTest
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
            this.listControlCollection1 = new HBD.WinForms.UserControls.ListControlCollection();
            this.button1 = new System.Windows.Forms.Button();
            this.listControlCollection1.WorkingArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // listControlCollection1
            // 
            this.listControlCollection1.AutoScroll = true;
            this.listControlCollection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listControlCollection1.Location = new System.Drawing.Point(0, 0);
            this.listControlCollection1.Name = "listControlCollection1";
            this.listControlCollection1.Size = new System.Drawing.Size(284, 485);
            this.listControlCollection1.TabIndex = 3;
            // 
            // listControlCollection1.WorkingArea
            // 
            this.listControlCollection1.WorkingArea.Controls.Add(this.button1);
            this.listControlCollection1.WorkingArea.Name = "WorkingArea";
            this.listControlCollection1.WorkingArea.Padding = new System.Windows.Forms.Padding(3);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddRemoveButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 485);
            this.Controls.Add(this.listControlCollection1);
            this.Name = "AddRemoveButtonTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRemoveButtonTest";
            this.listControlCollection1.WorkingArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.ListControlCollection listControlCollection1;
        private System.Windows.Forms.Button button1;
    }
}