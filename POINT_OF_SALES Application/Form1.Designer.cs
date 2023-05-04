namespace POINT_OF_SALES_Application
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADDitemBTN = new System.Windows.Forms.Button();
            this.REMOVEitenBTN = new System.Windows.Forms.Button();
            this.ClearAllBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TOTALlbl = new System.Windows.Forms.Label();
            this.TXTProdID = new System.Windows.Forms.TextBox();
            this.TXTProdName = new System.Windows.Forms.TextBox();
            this.TXTManufacturer = new System.Windows.Forms.TextBox();
            this.TXTUnitPrice = new System.Windows.Forms.TextBox();
            this.TXTQty = new System.Windows.Forms.TextBox();
            this.CustomerEntryStatusLBL = new System.Windows.Forms.Label();
            this.LBLitemaddSuccess = new System.Windows.Forms.Label();
            this.ERRLBL = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productWastageManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wastedItemReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_identify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRmvSelected = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProductgrpBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ProductgrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ADDitemBTN
            // 
            this.ADDitemBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADDitemBTN.Enabled = false;
            this.ADDitemBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDitemBTN.Location = new System.Drawing.Point(605, 190);
            this.ADDitemBTN.Name = "ADDitemBTN";
            this.ADDitemBTN.Size = new System.Drawing.Size(79, 53);
            this.ADDitemBTN.TabIndex = 5;
            this.ADDitemBTN.Text = "Add Item";
            this.ADDitemBTN.UseVisualStyleBackColor = false;
            this.ADDitemBTN.Click += new System.EventHandler(this.ADDitemBTN_Click);
            // 
            // REMOVEitenBTN
            // 
            this.REMOVEitenBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.REMOVEitenBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMOVEitenBTN.Location = new System.Drawing.Point(496, 190);
            this.REMOVEitenBTN.Name = "REMOVEitenBTN";
            this.REMOVEitenBTN.Size = new System.Drawing.Size(103, 53);
            this.REMOVEitenBTN.TabIndex = 6;
            this.REMOVEitenBTN.Text = "Remove Item";
            this.REMOVEitenBTN.UseVisualStyleBackColor = false;
            this.REMOVEitenBTN.Click += new System.EventHandler(this.REMOVEitenBTN_Click);
            // 
            // ClearAllBTN
            // 
            this.ClearAllBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearAllBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllBTN.Location = new System.Drawing.Point(345, 249);
            this.ClearAllBTN.Name = "ClearAllBTN";
            this.ClearAllBTN.Size = new System.Drawing.Size(130, 68);
            this.ClearAllBTN.TabIndex = 7;
            this.ClearAllBTN.Text = "Clear All";
            this.ClearAllBTN.UseVisualStyleBackColor = false;
            this.ClearAllBTN.Click += new System.EventHandler(this.ClearAllBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(626, 372);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "TOTAL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TOTALlbl
            // 
            this.TOTALlbl.AutoSize = true;
            this.TOTALlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTALlbl.Location = new System.Drawing.Point(403, 190);
            this.TOTALlbl.Name = "TOTALlbl";
            this.TOTALlbl.Size = new System.Drawing.Size(129, 20);
            this.TOTALlbl.TabIndex = 10;
            this.TOTALlbl.Text = "____________";
            // 
            // TXTProdID
            // 
            this.TXTProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTProdID.Location = new System.Drawing.Point(407, 20);
            this.TXTProdID.Name = "TXTProdID";
            this.TXTProdID.Size = new System.Drawing.Size(192, 26);
            this.TXTProdID.TabIndex = 11;
            this.TXTProdID.TextChanged += new System.EventHandler(this.TXTProdID_TextChanged);
            this.TXTProdID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTProdID_KeyPress);
            // 
            // TXTProdName
            // 
            this.TXTProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTProdName.Location = new System.Drawing.Point(407, 53);
            this.TXTProdName.Name = "TXTProdName";
            this.TXTProdName.ReadOnly = true;
            this.TXTProdName.Size = new System.Drawing.Size(192, 26);
            this.TXTProdName.TabIndex = 12;
            // 
            // TXTManufacturer
            // 
            this.TXTManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTManufacturer.Location = new System.Drawing.Point(407, 84);
            this.TXTManufacturer.Name = "TXTManufacturer";
            this.TXTManufacturer.ReadOnly = true;
            this.TXTManufacturer.Size = new System.Drawing.Size(192, 26);
            this.TXTManufacturer.TabIndex = 13;
            // 
            // TXTUnitPrice
            // 
            this.TXTUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUnitPrice.Location = new System.Drawing.Point(407, 117);
            this.TXTUnitPrice.Name = "TXTUnitPrice";
            this.TXTUnitPrice.ReadOnly = true;
            this.TXTUnitPrice.Size = new System.Drawing.Size(192, 26);
            this.TXTUnitPrice.TabIndex = 14;
            this.TXTUnitPrice.TextChanged += new System.EventHandler(this.TXTUnitPrice_TextChanged);
            // 
            // TXTQty
            // 
            this.TXTQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTQty.Location = new System.Drawing.Point(407, 146);
            this.TXTQty.Name = "TXTQty";
            this.TXTQty.Size = new System.Drawing.Size(116, 26);
            this.TXTQty.TabIndex = 15;
            this.TXTQty.TextChanged += new System.EventHandler(this.TXTQty_TextChanged);
            this.TXTQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTQty_KeyPress);
            // 
            // CustomerEntryStatusLBL
            // 
            this.CustomerEntryStatusLBL.AutoSize = true;
            this.CustomerEntryStatusLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEntryStatusLBL.Location = new System.Drawing.Point(335, 81);
            this.CustomerEntryStatusLBL.Name = "CustomerEntryStatusLBL";
            this.CustomerEntryStatusLBL.Size = new System.Drawing.Size(0, 20);
            this.CustomerEntryStatusLBL.TabIndex = 21;
            this.CustomerEntryStatusLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLitemaddSuccess
            // 
            this.LBLitemaddSuccess.AutoSize = true;
            this.LBLitemaddSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLitemaddSuccess.ForeColor = System.Drawing.Color.Lime;
            this.LBLitemaddSuccess.Location = new System.Drawing.Point(21, 127);
            this.LBLitemaddSuccess.Name = "LBLitemaddSuccess";
            this.LBLitemaddSuccess.Size = new System.Drawing.Size(0, 18);
            this.LBLitemaddSuccess.TabIndex = 22;
            // 
            // ERRLBL
            // 
            this.ERRLBL.AutoSize = true;
            this.ERRLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERRLBL.ForeColor = System.Drawing.Color.Lime;
            this.ERRLBL.Location = new System.Drawing.Point(20, 70);
            this.ERRLBL.Name = "ERRLBL";
            this.ERRLBL.Size = new System.Drawing.Size(0, 18);
            this.ERRLBL.TabIndex = 23;
            // 
            // BTN_OK
            // 
            this.BTN_OK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_OK.Enabled = false;
            this.BTN_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OK.Location = new System.Drawing.Point(534, 152);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(65, 33);
            this.BTN_OK.TabIndex = 24;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = false;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.makeNewDatasetToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 29);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSalesToolStripMenuItem,
            this.allProductsToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.productWastageManagementToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // allSalesToolStripMenuItem
            // 
            this.allSalesToolStripMenuItem.Name = "allSalesToolStripMenuItem";
            this.allSalesToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.allSalesToolStripMenuItem.Text = "All Sales";
            this.allSalesToolStripMenuItem.Click += new System.EventHandler(this.allSalesToolStripMenuItem_Click);
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.allProductsToolStripMenuItem.Text = "All Products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.loginToolStripMenuItem.Text = "Log Out";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.trainToolStripMenuItem.Text = "Analyze Training Plots";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // productWastageManagementToolStripMenuItem
            // 
            this.productWastageManagementToolStripMenuItem.Name = "productWastageManagementToolStripMenuItem";
            this.productWastageManagementToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.productWastageManagementToolStripMenuItem.Text = "Product Wastage Management";
            this.productWastageManagementToolStripMenuItem.Click += new System.EventHandler(this.productWastageManagementToolStripMenuItem_Click);
            // 
            // makeNewDatasetToolStripMenuItem
            // 
            this.makeNewDatasetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDatasetToolStripMenuItem,
            this.trainDatasetToolStripMenuItem});
            this.makeNewDatasetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeNewDatasetToolStripMenuItem.Name = "makeNewDatasetToolStripMenuItem";
            this.makeNewDatasetToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.makeNewDatasetToolStripMenuItem.Text = "Train";
            // 
            // newDatasetToolStripMenuItem
            // 
            this.newDatasetToolStripMenuItem.Name = "newDatasetToolStripMenuItem";
            this.newDatasetToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newDatasetToolStripMenuItem.Text = "New Dataset";
            this.newDatasetToolStripMenuItem.Click += new System.EventHandler(this.newDatasetToolStripMenuItem_Click);
            // 
            // trainDatasetToolStripMenuItem
            // 
            this.trainDatasetToolStripMenuItem.Name = "trainDatasetToolStripMenuItem";
            this.trainDatasetToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.trainDatasetToolStripMenuItem.Text = "Train Dataset";
            this.trainDatasetToolStripMenuItem.Click += new System.EventHandler(this.trainDatasetToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem,
            this.productReportToolStripMenuItem,
            this.wastedItemReportToolStripMenuItem,
            this.inventoryReportToolStripMenuItem,
            this.purchaseOrderReportToolStripMenuItem,
            this.deliveryReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // productReportToolStripMenuItem
            // 
            this.productReportToolStripMenuItem.Name = "productReportToolStripMenuItem";
            this.productReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.productReportToolStripMenuItem.Text = "Product Report";
            this.productReportToolStripMenuItem.Click += new System.EventHandler(this.productReportToolStripMenuItem_Click);
            // 
            // wastedItemReportToolStripMenuItem
            // 
            this.wastedItemReportToolStripMenuItem.Name = "wastedItemReportToolStripMenuItem";
            this.wastedItemReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.wastedItemReportToolStripMenuItem.Text = "Wasted Item Report";
            this.wastedItemReportToolStripMenuItem.Click += new System.EventHandler(this.wastedItemReportToolStripMenuItem_Click);
            // 
            // inventoryReportToolStripMenuItem
            // 
            this.inventoryReportToolStripMenuItem.Name = "inventoryReportToolStripMenuItem";
            this.inventoryReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.inventoryReportToolStripMenuItem.Text = "Inventory Report";
            this.inventoryReportToolStripMenuItem.Click += new System.EventHandler(this.inventoryReportToolStripMenuItem_Click);
            // 
            // purchaseOrderReportToolStripMenuItem
            // 
            this.purchaseOrderReportToolStripMenuItem.Name = "purchaseOrderReportToolStripMenuItem";
            this.purchaseOrderReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.purchaseOrderReportToolStripMenuItem.Text = "Purchase Order Report";
            this.purchaseOrderReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderReportToolStripMenuItem_Click);
            // 
            // deliveryReportToolStripMenuItem
            // 
            this.deliveryReportToolStripMenuItem.Name = "deliveryReportToolStripMenuItem";
            this.deliveryReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deliveryReportToolStripMenuItem.Text = "Delivery Report";
            this.deliveryReportToolStripMenuItem.Click += new System.EventHandler(this.deliveryReportToolStripMenuItem_Click);
            // 
            // BTN_identify
            // 
            this.BTN_identify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_identify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_identify.Location = new System.Drawing.Point(481, 249);
            this.BTN_identify.Name = "BTN_identify";
            this.BTN_identify.Size = new System.Drawing.Size(203, 67);
            this.BTN_identify.TabIndex = 26;
            this.BTN_identify.Text = "Identify Product";
            this.BTN_identify.UseVisualStyleBackColor = false;
            this.BTN_identify.Click += new System.EventHandler(this.BTN_identify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintBill);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(704, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 426);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Bill";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Location = new System.Drawing.Point(14, 396);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(137, 33);
            this.btnPrintBill.TabIndex = 35;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRmvSelected);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.BTN_identify);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BTN_OK);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CustomerEntryStatusLBL);
            this.groupBox2.Controls.Add(this.ADDitemBTN);
            this.groupBox2.Controls.Add(this.TXTQty);
            this.groupBox2.Controls.Add(this.REMOVEitenBTN);
            this.groupBox2.Controls.Add(this.TXTUnitPrice);
            this.groupBox2.Controls.Add(this.ClearAllBTN);
            this.groupBox2.Controls.Add(this.TXTManufacturer);
            this.groupBox2.Controls.Add(this.TOTALlbl);
            this.groupBox2.Controls.Add(this.TXTProdName);
            this.groupBox2.Controls.Add(this.TXTProdID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 326);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRmvSelected
            // 
            this.btnRmvSelected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRmvSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvSelected.Location = new System.Drawing.Point(209, 248);
            this.btnRmvSelected.Name = "btnRmvSelected";
            this.btnRmvSelected.Size = new System.Drawing.Size(130, 68);
            this.btnRmvSelected.TabIndex = 28;
            this.btnRmvSelected.Text = "Remove Selected";
            this.btnRmvSelected.UseVisualStyleBackColor = false;
            this.btnRmvSelected.Click += new System.EventHandler(this.btnRmvSelected_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POINT_OF_SALES_Application.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(5, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // ProductgrpBox
            // 
            this.ProductgrpBox.BackColor = System.Drawing.Color.Lavender;
            this.ProductgrpBox.Controls.Add(this.pictureBox1);
            this.ProductgrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductgrpBox.Location = new System.Drawing.Point(7, 359);
            this.ProductgrpBox.Name = "ProductgrpBox";
            this.ProductgrpBox.Size = new System.Drawing.Size(691, 340);
            this.ProductgrpBox.TabIndex = 29;
            this.ProductgrpBox.TabStop = false;
            this.ProductgrpBox.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(108, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 300);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ERRLBL);
            this.groupBox3.Controls.Add(this.LBLitemaddSuccess);
            this.groupBox3.Location = new System.Drawing.Point(704, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 239);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.CurrentChanged += new System.EventHandler(this.DataTable1BindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1344, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ProductgrpBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ProductgrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ADDitemBTN;
        private System.Windows.Forms.Button REMOVEitenBTN;
        private System.Windows.Forms.Button ClearAllBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TOTALlbl;
        private System.Windows.Forms.TextBox TXTProdID;
        private System.Windows.Forms.TextBox TXTProdName;
        private System.Windows.Forms.TextBox TXTManufacturer;
        private System.Windows.Forms.TextBox TXTUnitPrice;
        private System.Windows.Forms.TextBox TXTQty;
        private System.Windows.Forms.Label CustomerEntryStatusLBL;
        private System.Windows.Forms.Label LBLitemaddSuccess;
        private System.Windows.Forms.Label ERRLBL;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Button BTN_identify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ProductgrpBox;
        private System.Windows.Forms.ToolStripMenuItem makeNewDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productWastageManagementToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRmvSelected;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wastedItemReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryReportToolStripMenuItem;
       
    }
}

