using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using System.Data.SqlClient;

namespace POINT_OF_SALES_Application
{
    public partial class ExtFeatureAndTrain : Form
    {
        bool Extraction_done = false;//--------------FLAG for Extraction Status
        bool Train_Done = false;//-------------------FLAG for Training Status
        bool flag_sample = false;//--------------FLAG for No. Of Samples
        //bool flag_totImages = false;
        bool flag_Neurons = false;//--------------FLAG for Neurons
        bool flag_epochs = false;//--------------FLAG for Epochs
        bool flag_alpha = false;//--------------FLAG for alpha
        public ExtFeatureAndTrain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {//----------------On Browse Button Click Show Folder Browser
            FolderBrowserDialog objfbd = new FolderBrowserDialog();
            objfbd.ShowDialog();
            lblPath.Text = objfbd.SelectedPath;//--------------------Save the selected PAth in the label
        }

        private void ExtFeatureAndTrain_Load(object sender, EventArgs e)
        {
            //-----------------Initialize All FLAG with FALSE
            btnExtractFeatures.Enabled = false;
            btnTrain.Enabled = false;
            txtAlpha.Enabled = false;
            txtEpochs.Enabled = false;
            txtNeurons.Enabled = false;
            //txtTotalImages.Enabled = false;
            txtSamples.Enabled = false;
        }

        private void lblPath_TextChanged(object sender, EventArgs e)
        {
            //---------When Path is Set then Enable the Samples Textbox
            txtSamples.Enabled = true;

        }

       
        private void txtSamples_KeyPress(object sender, KeyPressEventArgs e)
        {
            //--------------DisAllow Character Input in Numeric TextBoxes
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {//----------------TRUE Sample FLAG
                flag_sample = true;
            }
        }

        private void txtNeurons_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                flag_Neurons = true;
            }

        }

        private void txtEpochs_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                flag_epochs = true;
            }
        }

        private void txtAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                flag_alpha = true;
            }



            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }
            else
            {
                flag_alpha = true;
            }

        }

        private void txtAlpha_TextChanged(object sender, EventArgs e)
        {
            //-------Check ALPHA, NEURONS & EPOCHS textboxes are not Empty then Enable the Train Button
            if (!string.IsNullOrEmpty(txtAlpha.Text) && !string.IsNullOrEmpty(txtNeurons.Text) && !string.IsNullOrEmpty(txtEpochs.Text))
                btnTrain.Enabled = true;
            else
                //-------------Else Disable TRAIN Button
                btnTrain.Enabled = false;
        }

        private void txtSamples_TextChanged(object sender, EventArgs e)
        {
            if (flag_sample == true)//--------------If SAMPLS are given Enable EXtract Features Button
            {
                btnExtractFeatures.Enabled = true;
                if (txtSamples.Text == "")//--------------If Samples TExtbox is empty then Disable the EXtrac Featurs Button
                {
                    btnExtractFeatures.Enabled = false;
                }
            }  
            
        }

        private void txtNeurons_TextChanged(object sender, EventArgs e)
        {//--------------If All Required input are given then Proceed
            if (flag_Neurons == true && flag_epochs == true && flag_alpha == true)
            {
                btnTrain.Enabled = true;//--------------Enable Trains
                if (txtNeurons.Text == "")
                {
                    btnTrain.Enabled = false;
                }
            }  
        }

        private void txtEpochs_TextChanged(object sender, EventArgs e)
        {//--------------If All Required input are given then Proceed
            if (flag_Neurons == true && flag_epochs == true && flag_alpha == true)
            {
                btnTrain.Enabled = true;
                if (txtEpochs.Text == "")
                {
                    btnTrain.Enabled = false;
                }
            }  
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {//--------------Show the Loading Screen While Training Use Background Worker For this
                backgroundWorker_Train.RunWorkerAsync();//--------------Run The Training Proces in Background worker
                LoadingControl_ForTrain();//--------------Show The Loading Screen
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        public void LoadingControl_ForExtraction()
        {           
            LoadingForm load = new LoadingForm();
            if (Extraction_done == true)
            {                
                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "LoadingForm")
                    {
                        Application.OpenForms[index ].Close();
                    }
                }
                this.Show();
            }
            else
            {
                this.Hide();
                load.Show();
            }
           
        }
        public void LoadingControl_ForTrain()
        {
            // Save the Folder path in DAtabase where Datset is SAVED in 
            LoadingForm load = new LoadingForm();           
            if (Train_Done == true)//-------------------------If Traning is Done then save the Path and Close the Load Form
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
                conn.Open();
                SqlDataAdapter adp= new SqlDataAdapter("select * from Directory", conn);
                DataSet ds= new DataSet();
                SqlCommandBuilder buil = new SqlCommandBuilder(adp);
                adp.Fill(ds, "Directory");
                SqlCommand comPO_IsClosed = new SqlCommand("update Directory set path = '" + lblPath .Text  + "' where path_ID=1", conn);
                comPO_IsClosed.ExecuteNonQuery();
                conn.Close();

                TrainingVariablesPath objPath = new TrainingVariablesPath();
                objPath.Directory_Path = lblPath.Text;

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "LoadingForm")
                    {
                        Application.OpenForms[index].Close();
                    }
                }
                this.Show();
            }
            else
            {
                this.Hide();
                load.Show();
            }

        }
        private void btnExtractFeatures_Click(object sender, EventArgs e)
        {
            //this .Enabled = false;
            //LoadingForm load = new LoadingForm();
            //load.Show();
             backgroundWorker_FExt.RunWorkerAsync();
             LoadingControl_ForExtraction();


            txtNeurons.Enabled = txtAlpha.Enabled = txtEpochs.Enabled = true;

        }

        private void backgroundWorker_FExt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.Enabled = true;
            LoadingControl_ForExtraction();

        }

        private void backgroundWorker_FExt_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
                int samples = Convert.ToInt32(txtSamples.Text);//---------------Get Samples as INT
                FeatureEXTRACT.Class1 objEXT = new FeatureEXTRACT.Class1();//---Creting Object
                MWArray func = (MWArray)objEXT.ExtractFuncWithPath((MWArray)lblPath.Text, (MWArray)samples);// Calling MATLAB func
                                                                                                           // And Passing Samples as Argument
                Extraction_done = true;//-------------Setting Features Etraction FLAG to TRUE
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { }            
        }

        private void backgroundWorker_FExt_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_Train_DoWork(object sender, DoWorkEventArgs e)
        {
            int Neurons = Convert.ToInt32(txtNeurons.Text);
            int Epochs = Convert.ToInt32(txtEpochs.Text);
            double alpha = Convert.ToDouble(txtAlpha.Text);
            try
            {
                TrainingFuncNEW.Class1 objTrain = new TrainingFuncNEW.Class1();//---Creting Object
                MWArray func = (MWNumericArray)objTrain.TrainFunction((MWArray)lblPath.Text, (MWArray)Neurons, (MWArray)alpha, (MWArray)Epochs);
                Train_Done = true;//-------------Setting Features Training FLAG to TRUE
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Train_Done = true;
            }

        }

        private void backgroundWorker_Train_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingControl_ForTrain ();
        }


    }
}
