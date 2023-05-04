namespace POINT_OF_SALES_Application
{
    partial class TainingPlotForm
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
            this.txtNeurons = new System.Windows.Forms.TextBox();
            this.txtEpochs = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblWait = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neurons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Epochs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Learning Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "(alpha)";
            // 
            // txtNeurons
            // 
            this.txtNeurons.Location = new System.Drawing.Point(114, 34);
            this.txtNeurons.MaxLength = 3;
            this.txtNeurons.Name = "txtNeurons";
            this.txtNeurons.Size = new System.Drawing.Size(122, 20);
            this.txtNeurons.TabIndex = 4;
            this.txtNeurons.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            this.txtNeurons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNeurons_KeyPress);
            // 
            // txtEpochs
            // 
            this.txtEpochs.Location = new System.Drawing.Point(114, 69);
            this.txtEpochs.MaxLength = 3;
            this.txtEpochs.Name = "txtEpochs";
            this.txtEpochs.Size = new System.Drawing.Size(122, 20);
            this.txtEpochs.TabIndex = 5;
            this.txtEpochs.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            this.txtEpochs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEpochs_KeyPress);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(133, 134);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(147, 173);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(0, 13);
            this.lblWait.TabIndex = 8;
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(114, 102);
            this.txtAlpha.Mask = ".00000";
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(122, 20);
            this.txtAlpha.TabIndex = 9;
            // 
            // TainingPlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 209);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtEpochs);
            this.Controls.Add(this.txtNeurons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TainingPlotForm";
            this.Text = "Taining";
            this.Load += new System.EventHandler(this.Taining_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNeurons;
        private System.Windows.Forms.TextBox txtEpochs;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.MaskedTextBox txtAlpha;
    }
}