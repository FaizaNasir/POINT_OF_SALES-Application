namespace POINT_OF_SALES_Application
{
    partial class ExtFeatureAndTrain
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
            this.txtAlpha = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEpochs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPleasewait = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSamples = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.txtNeurons = new System.Windows.Forms.TextBox();
            this.btnExtractFeatures = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.backgroundWorker_FExt = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_Train = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(97, 117);
            this.txtAlpha.Mask = ".0000";
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(100, 22);
            this.txtAlpha.TabIndex = 24;
            this.txtAlpha.TextChanged += new System.EventHandler(this.txtAlpha_TextChanged);
            this.txtAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlpha_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Epochs";
            // 
            // txtEpochs
            // 
            this.txtEpochs.Location = new System.Drawing.Point(97, 75);
            this.txtEpochs.Name = "txtEpochs";
            this.txtEpochs.Size = new System.Drawing.Size(100, 22);
            this.txtEpochs.TabIndex = 23;
            this.txtEpochs.TextChanged += new System.EventHandler(this.txtEpochs_TextChanged);
            this.txtEpochs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEpochs_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Neurons";
            // 
            // lblPleasewait
            // 
            this.lblPleasewait.AutoSize = true;
            this.lblPleasewait.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleasewait.ForeColor = System.Drawing.Color.Red;
            this.lblPleasewait.Location = new System.Drawing.Point(6, 127);
            this.lblPleasewait.Name = "lblPleasewait";
            this.lblPleasewait.Size = new System.Drawing.Size(0, 18);
            this.lblPleasewait.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Samples";
            // 
            // txtSamples
            // 
            this.txtSamples.Location = new System.Drawing.Point(95, 26);
            this.txtSamples.Name = "txtSamples";
            this.txtSamples.Size = new System.Drawing.Size(100, 22);
            this.txtSamples.TabIndex = 27;
            this.txtSamples.TextChanged += new System.EventHandler(this.txtSamples_TextChanged);
            this.txtSamples.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSamples_KeyPress);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(203, 66);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(143, 42);
            this.btnTrain.TabIndex = 25;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // txtNeurons
            // 
            this.txtNeurons.Location = new System.Drawing.Point(97, 35);
            this.txtNeurons.Name = "txtNeurons";
            this.txtNeurons.Size = new System.Drawing.Size(100, 22);
            this.txtNeurons.TabIndex = 22;
            this.txtNeurons.TextChanged += new System.EventHandler(this.txtNeurons_TextChanged);
            this.txtNeurons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNeurons_KeyPress);
            // 
            // btnExtractFeatures
            // 
            this.btnExtractFeatures.Location = new System.Drawing.Point(203, 21);
            this.btnExtractFeatures.Name = "btnExtractFeatures";
            this.btnExtractFeatures.Size = new System.Drawing.Size(143, 42);
            this.btnExtractFeatures.TabIndex = 17;
            this.btnExtractFeatures.Text = "Extract Features";
            this.btnExtractFeatures.UseVisualStyleBackColor = true;
            this.btnExtractFeatures.Click += new System.EventHandler(this.btnExtractFeatures_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alpha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPleasewait);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSamples);
            this.groupBox1.Controls.Add(this.btnExtractFeatures);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extract Features";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.Controls.Add(this.txtNeurons);
            this.groupBox2.Controls.Add(this.txtAlpha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEpochs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(104, 33);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(265, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "___________________________________________";
            this.lblPath.TextChanged += new System.EventHandler(this.lblPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(12, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 42);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // backgroundWorker_FExt
            // 
            this.backgroundWorker_FExt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_FExt_DoWork);
            this.backgroundWorker_FExt.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_FExt_ProgressChanged);
            this.backgroundWorker_FExt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_FExt_RunWorkerCompleted);
            // 
            // backgroundWorker_Train
            // 
            this.backgroundWorker_Train.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Train_DoWork);
            this.backgroundWorker_Train.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Train_RunWorkerCompleted);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POINT_OF_SALES_Application.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(185, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // ExtFeatureAndTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 362);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "ExtFeatureAndTrain";
            this.Text = "ExtFeatureAndTrain";
            this.Load += new System.EventHandler(this.ExtFeatureAndTrain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtAlpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEpochs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPleasewait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSamples;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TextBox txtNeurons;
        private System.Windows.Forms.Button btnExtractFeatures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.ComponentModel.BackgroundWorker backgroundWorker_FExt;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Train;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}