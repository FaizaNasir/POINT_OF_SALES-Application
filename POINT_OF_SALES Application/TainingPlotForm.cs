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



namespace POINT_OF_SALES_Application
{
    public partial class TainingPlotForm : Form
    {

        public TainingPlotForm()
        {


            InitializeComponent();
        }

        private void Taining_Load(object sender, EventArgs e)
        {
            btnAnalyze.Enabled = false;

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            //int range = 4;
            //Random_NumbersGenerator.Test obj = new Random_NumbersGenerator.Test();
            //MWArray random_number = (MWNumericArray)obj.random_number_generator((MWArray)range);
            //TXTProdID.Text = random_number.ToString();



            int Neurons = Convert.ToInt32(txtNeurons.Text);
            int Epochs = Convert.ToInt32(txtEpochs.Text);
            double alpha = Convert.ToDouble(txtAlpha.Text);
            try
            {

                TrainNew.Class1 obj_train = new TrainNew.Class1();
                MWArray func = (MWNumericArray)obj_train.TrainFunction((MWArray)Neurons, (MWArray)alpha, (MWArray)Epochs);

            }
            catch (Exception ex)
            {

            }





        }

        private void txtNeurons_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                
            }


        }

        private void txtEpochs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }
        }

        private void txtAlpha_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtAlpha.Text) && !string.IsNullOrEmpty(txtNeurons.Text) && !string.IsNullOrEmpty(txtEpochs.Text))

                btnAnalyze.Enabled = true;

            else

                btnAnalyze.Enabled = false;
        }

       
    }
}
