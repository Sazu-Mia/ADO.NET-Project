namespace Project
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportWithImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.donorsToolStripMenuItem,
            this.hospitalToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editDeleteToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editDeleteToolStripMenuItem
            // 
            this.editDeleteToolStripMenuItem.Name = "editDeleteToolStripMenuItem";
            this.editDeleteToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.editDeleteToolStripMenuItem.Text = "Edit/Delete";
            this.editDeleteToolStripMenuItem.Click += new System.EventHandler(this.editDeleteToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.addToolStripMenuItem1,
            this.editDeleteToolStripMenuItem1});
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.donorsToolStripMenuItem.Text = "Donors";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.viewToolStripMenuItem1.Text = "View ";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editDeleteToolStripMenuItem1
            // 
            this.editDeleteToolStripMenuItem1.Name = "editDeleteToolStripMenuItem1";
            this.editDeleteToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.editDeleteToolStripMenuItem1.Text = "Edit/Delete";
            this.editDeleteToolStripMenuItem1.Click += new System.EventHandler(this.editDeleteToolStripMenuItem1_Click);
            // 
            // hospitalToolStripMenuItem
            // 
            this.hospitalToolStripMenuItem.Name = "hospitalToolStripMenuItem";
            this.hospitalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hospitalToolStripMenuItem.Text = "Hospital";
            this.hospitalToolStripMenuItem.Click += new System.EventHandler(this.hospitalToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleReportToolStripMenuItem,
            this.groupReportToolStripMenuItem,
            this.reportWithImageToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // simpleReportToolStripMenuItem
            // 
            this.simpleReportToolStripMenuItem.Name = "simpleReportToolStripMenuItem";
            this.simpleReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.simpleReportToolStripMenuItem.Text = "Simple Report";
            this.simpleReportToolStripMenuItem.Click += new System.EventHandler(this.simpleReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupReportToolStripMenuItem
            // 
            this.groupReportToolStripMenuItem.Name = "groupReportToolStripMenuItem";
            this.groupReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.groupReportToolStripMenuItem.Text = "Group Report";
            this.groupReportToolStripMenuItem.Click += new System.EventHandler(this.groupReportToolStripMenuItem_Click);
            // 
            // reportWithImageToolStripMenuItem
            // 
            this.reportWithImageToolStripMenuItem.Name = "reportWithImageToolStripMenuItem";
            this.reportWithImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportWithImageToolStripMenuItem.Text = "Report with image";
            this.reportWithImageToolStripMenuItem.Click += new System.EventHandler(this.reportWithImageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 509);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editDeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportWithImageToolStripMenuItem;
    }
}

