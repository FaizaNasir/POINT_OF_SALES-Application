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
using System.IO;


namespace POINT_OF_SALES_Application
{
    public partial class CaptureImagesForm : Form
    {
        //----------Flag for image cature
        bool Image_captured;

        public CaptureImagesForm()
        {
            InitializeComponent();
        }


        //-------------Button for Capture IMage
        private void btnCapture_Click(object sender, EventArgs e)
        {
            //-------Background Worker for Image Capturing
            b_WorkerCaptureImage.RunWorkerAsync(); //-----------
            

            //--------While system is processing show a loading scree
            LoadingControl_ForImageCapture(); //-----------


        }
        public void LoadingControl_ForImageCapture()
        {
            //-------Show Loading Scree
            LoadingForm load = new LoadingForm();
            if (Image_captured  == true) // If image capture Flag is True
            {
                for (int index = Application.OpenForms.Count - 1; index >= 0; index--) //------Loop through all Open Forms
                {
                    if (Application.OpenForms[index].Name == "LoadingForm") //-----If Loading Screen Form is Opened 
                    {
                        Application.OpenForms[index].Close();// ------Then claose that Form
                    }
                }
                this.Show(); //-----And show the Current Form
            }
            else
            { //---------If image capture flag is false i.e The image is not captured yet then
                //-------hide this form and show the Loading Screen
                this.Hide();
                load.Show();
            }
           
        }

        
        private void b_WorkerCaptureImage_DoWork(object sender, DoWorkEventArgs e)
        {
            //-------------Calling MAtlab Function to Capture and Save image
            webcam_app.Class1 objCameraApp = new webcam_app.Class1 ();
            MWArray matlabFunc = (MWArray)objCameraApp.webcam_app((MWArray)lblPath.Text);

            //------------Getting the Latest Creted file from the Folder
            var directory = new DirectoryInfo(lblPath .Text );
            var Latest_Image = directory.GetFiles("*.jpg")
             .OrderByDescending(img => img.LastWriteTime)
             .First();
            
            //--------Show Image on PictureBox
            Image image = Image.FromFile(lblPath.Text + "/" + Latest_Image.ToString());
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_captured = true;
        }
        private void b_WorkerCaptureImage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadingControl_ForImageCapture();
        }

        private void lblPath_TextChanged(object sender, EventArgs e)
        {
            //------------On Selecting Path Enable the Capture Button
            btnCapture.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
                lblPath.Text = folderBrowserDialog1.SelectedPath;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }
   
    }
}
