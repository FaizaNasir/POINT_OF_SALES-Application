namespace POINT_OF_SALES_Application
{
    partial class SignupForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxAddress = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCNIC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxContct = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxUName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPassword = new System.Windows.Forms.TextBox();
            this.maskedTextBoxConfirmPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CNIC";
            // 
            // maskedTextBoxAddress
            // 
            this.maskedTextBoxAddress.Location = new System.Drawing.Point(173, 236);
            this.maskedTextBoxAddress.Name = "maskedTextBoxAddress";
            this.maskedTextBoxAddress.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxAddress.TabIndex = 12;
            // 
            // maskedTextBoxCNIC
            // 
            this.maskedTextBoxCNIC.Location = new System.Drawing.Point(173, 187);
            this.maskedTextBoxCNIC.Mask = "00000-0000000-0";
            this.maskedTextBoxCNIC.Name = "maskedTextBoxCNIC";
            this.maskedTextBoxCNIC.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxCNIC.TabIndex = 13;
            // 
            // maskedTextBoxContct
            // 
            this.maskedTextBoxContct.Location = new System.Drawing.Point(173, 147);
            this.maskedTextBoxContct.Mask = "(99) 000-0000000";
            this.maskedTextBoxContct.Name = "maskedTextBoxContct";
            this.maskedTextBoxContct.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxContct.TabIndex = 14;
            this.maskedTextBoxContct.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxContct_MaskInputRejected);
            this.maskedTextBoxContct.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxContct_TypeValidationCompleted);
            // 
            // maskedTextBoxUName
            // 
            this.maskedTextBoxUName.Location = new System.Drawing.Point(173, 19);
            this.maskedTextBoxUName.MaxLength = 50;
            this.maskedTextBoxUName.MinimumSize = new System.Drawing.Size(6, 20);
            this.maskedTextBoxUName.Name = "maskedTextBoxUName";
            this.maskedTextBoxUName.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxUName.TabIndex = 16;
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(173, 59);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxPassword.TabIndex = 17;
            this.maskedTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // maskedTextBoxConfirmPW
            // 
            this.maskedTextBoxConfirmPW.Location = new System.Drawing.Point(173, 106);
            this.maskedTextBoxConfirmPW.Name = "maskedTextBoxConfirmPW";
            this.maskedTextBoxConfirmPW.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxConfirmPW.TabIndex = 18;
            this.maskedTextBoxConfirmPW.UseSystemPasswordChar = true;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 326);
            this.Controls.Add(this.maskedTextBoxConfirmPW);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.maskedTextBoxUName);
            this.Controls.Add(this.maskedTextBoxContct);
            this.Controls.Add(this.maskedTextBoxCNIC);
            this.Controls.Add(this.maskedTextBoxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNIC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContct;
        private System.Windows.Forms.TextBox maskedTextBoxUName;
        private System.Windows.Forms.TextBox maskedTextBoxPassword;
        private System.Windows.Forms.TextBox maskedTextBoxConfirmPW;
    }
}