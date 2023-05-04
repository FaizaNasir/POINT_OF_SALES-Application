namespace POINT_OF_SALES_Application
{
    partial class RepInventory
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
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptInventory2 = new POINT_OF_SALES_Application.RptInventory();
            this.RptInventory1 = new POINT_OF_SALES_Application.RptInventory();
            this.getReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProfitLossStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getReportToolStripMenuItem,
            this.getProfitLossStatusToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 24);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RptInventory2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(854, 402);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // getReportToolStripMenuItem
            // 
            this.getReportToolStripMenuItem.Name = "getReportToolStripMenuItem";
            this.getReportToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.getReportToolStripMenuItem.Text = "Get Report";
            this.getReportToolStripMenuItem.Click += new System.EventHandler(this.getReportToolStripMenuItem_Click);
            // 
            // getProfitLossStatusToolStripMenuItem
            // 
            this.getProfitLossStatusToolStripMenuItem.Name = "getProfitLossStatusToolStripMenuItem";
            this.getProfitLossStatusToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.getProfitLossStatusToolStripMenuItem.Text = "Get Profit Loss Status";
            this.getProfitLossStatusToolStripMenuItem.Click += new System.EventHandler(this.getProfitLossStatusToolStripMenuItem_Click);
            // 
            // RepInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 426);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RepInventory";
            this.Text = "RepInventory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RptInventory RptInventory1;
        private RptInventory RptInventory2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProfitLossStatusToolStripMenuItem;
    }
}