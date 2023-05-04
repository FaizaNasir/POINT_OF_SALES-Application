namespace POINT_OF_SALES_Application
{
    partial class Delivery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPORate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeliveryRate = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtQty_Delivered = new System.Windows.Forms.TextBox();
            this.cboPurchaseOrder = new System.Windows.Forms.ComboBox();
            this.btnAddDelivery = new System.Windows.Forms.Button();
            this.txtQtyOrderd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "P.O Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qty_Ordered";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(169, 79);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(277, 24);
            this.txtProductName.TabIndex = 5;
            // 
            // txtPORate
            // 
            this.txtPORate.Location = new System.Drawing.Point(169, 128);
            this.txtPORate.Name = "txtPORate";
            this.txtPORate.Size = new System.Drawing.Size(72, 24);
            this.txtPORate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Delivery Rate ";
            // 
            // txtDeliveryRate
            // 
            this.txtDeliveryRate.Location = new System.Drawing.Point(374, 125);
            this.txtDeliveryRate.Name = "txtDeliveryRate";
            this.txtDeliveryRate.Size = new System.Drawing.Size(72, 24);
            this.txtDeliveryRate.TabIndex = 8;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(169, 176);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(277, 24);
            this.txtManufacturer.TabIndex = 9;
            // 
            // txtQty_Delivered
            // 
            this.txtQty_Delivered.Location = new System.Drawing.Point(374, 229);
            this.txtQty_Delivered.Name = "txtQty_Delivered";
            this.txtQty_Delivered.Size = new System.Drawing.Size(72, 24);
            this.txtQty_Delivered.TabIndex = 10;
            // 
            // cboPurchaseOrder
            // 
            this.cboPurchaseOrder.FormattingEnabled = true;
            this.cboPurchaseOrder.Location = new System.Drawing.Point(169, 33);
            this.cboPurchaseOrder.Name = "cboPurchaseOrder";
            this.cboPurchaseOrder.Size = new System.Drawing.Size(277, 26);
            this.cboPurchaseOrder.TabIndex = 11;
            this.cboPurchaseOrder.SelectedIndexChanged += new System.EventHandler(this.cboPurchaseOrder_SelectedIndexChanged);
            // 
            // btnAddDelivery
            // 
            this.btnAddDelivery.Location = new System.Drawing.Point(223, 275);
            this.btnAddDelivery.Name = "btnAddDelivery";
            this.btnAddDelivery.Size = new System.Drawing.Size(145, 43);
            this.btnAddDelivery.TabIndex = 12;
            this.btnAddDelivery.Text = "Add Delivery";
            this.btnAddDelivery.UseVisualStyleBackColor = true;
            this.btnAddDelivery.Click += new System.EventHandler(this.btnAddDelivery_Click);
            // 
            // txtQtyOrderd
            // 
            this.txtQtyOrderd.Location = new System.Drawing.Point(169, 229);
            this.txtQtyOrderd.Name = "txtQtyOrderd";
            this.txtQtyOrderd.Size = new System.Drawing.Size(72, 24);
            this.txtQtyOrderd.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Qty_Delivered";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQtyOrderd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddDelivery);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboPurchaseOrder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQty_Delivered);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtManufacturer);
            this.groupBox1.Controls.Add(this.txtPORate);
            this.groupBox1.Controls.Add(this.txtDeliveryRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 335);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POINT_OF_SALES_Application.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(303, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 404);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPORate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeliveryRate;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtQty_Delivered;
        private System.Windows.Forms.ComboBox cboPurchaseOrder;
        private System.Windows.Forms.Button btnAddDelivery;
        private System.Windows.Forms.TextBox txtQtyOrderd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}