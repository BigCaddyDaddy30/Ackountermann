namespace Ackountermann
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountsReceivableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsPayableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceController1
            // 
            this.serviceController1.MachineName = "DESKTOP-U5O598U";
            this.serviceController1.ServiceName = "MSSQL$SQLEXPRESS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsReceivableToolStripMenuItem,
            this.accountsPayableToolStripMenuItem,
            this.payrollToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountsReceivableToolStripMenuItem
            // 
            this.accountsReceivableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorsToolStripMenuItem,
            this.vendorsToolStripMenuItem1});
            this.accountsReceivableToolStripMenuItem.Name = "accountsReceivableToolStripMenuItem";
            this.accountsReceivableToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.accountsReceivableToolStripMenuItem.Text = "Accounts Payable";
            // 
            // accountsPayableToolStripMenuItem
            // 
            this.accountsPayableToolStripMenuItem.Name = "accountsPayableToolStripMenuItem";
            this.accountsPayableToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.accountsPayableToolStripMenuItem.Text = "Accounts Receivable";
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendorsToolStripMenuItem.Text = "Vendor Invoices";
            // 
            // vendorsToolStripMenuItem1
            // 
            this.vendorsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVendorToolStripMenuItem,
            this.allVendorsToolStripMenuItem});
            this.vendorsToolStripMenuItem1.Name = "vendorsToolStripMenuItem1";
            this.vendorsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vendorsToolStripMenuItem1.Text = "Vendors";
            // 
            // allVendorsToolStripMenuItem
            // 
            this.allVendorsToolStripMenuItem.Name = "allVendorsToolStripMenuItem";
            this.allVendorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allVendorsToolStripMenuItem.Text = "All Vendors";
            // 
            // newVendorToolStripMenuItem
            // 
            this.newVendorToolStripMenuItem.Name = "newVendorToolStripMenuItem";
            this.newVendorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newVendorToolStripMenuItem.Text = "New Vendor";
            this.newVendorToolStripMenuItem.Click += new System.EventHandler(this.newVendorToolStripMenuItem_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ackountermann Software";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountsReceivableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsPayableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVendorToolStripMenuItem;
    }
}

