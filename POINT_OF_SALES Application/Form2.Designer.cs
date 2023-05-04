namespace POINT_OF_SALES_Application
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.POSdbDataSet = new POINT_OF_SALES_Application.POSdbDataSet();
            this.PurchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PurchaseOrderTableAdapter = new POINT_OF_SALES_Application.POSdbDataSetTableAdapters.PurchaseOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.POSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MYYY";
            reportDataSource1.Value = this.PurchaseOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POINT_OF_SALES_Application.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // POSdbDataSet
            // 
            this.POSdbDataSet.DataSetName = "POSdbDataSet";
            this.POSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PurchaseOrderBindingSource
            // 
            this.PurchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.PurchaseOrderBindingSource.DataSource = this.POSdbDataSet;
            // 
            // PurchaseOrderTableAdapter
            // 
            this.PurchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.POSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PurchaseOrderBindingSource;
        private POSdbDataSet POSdbDataSet;
        private POSdbDataSetTableAdapters.PurchaseOrderTableAdapter PurchaseOrderTableAdapter;
    }
}