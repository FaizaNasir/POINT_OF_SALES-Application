using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
//using MathWorks.MATLAB.NET.ComponentData;
using System.Text.RegularExpressions;
using MathWorks.MATLAB.NET.Utility;
//using MATLAB_NN_CODE;
//using CHKKK;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace POINT_OF_SALES_Application
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        
        //private void BTNADDcust_Click(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    Customer cust = new Customer();
        //    //    cust.set_Customer_Name(TXTCustomerName.Text);
        //    //    CustomerEntryStatusLBL.Text = cust.status;
        //    //    LBLcustID.Text = cust.Cust_ID;
        //    //}
          
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.AllowUserToAddRows = false;//------------------Disallow user to make changes in the Grid
            this.AutoSize = true;//--------------------------------------Autosize the Form
            
            //-----------------Make a DataTable for Bill and add the Following Rows in it. and specifying their data Types
            dt.Columns.Add("ProductID", typeof(string));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Manufacture", typeof(string));
            dt.Columns.Add("Unit Price", typeof(string ));
            dt.Columns.Add("Quantity", typeof(string ));
            dt.Columns.Add("Total", typeof(float));

            //---------------Create SQL Con
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            conn.Open();
            //--------------Select the path in which the dataset is stored
            SqlCommand com = new SqlCommand("select * from Directory where path_ID = 1 ", conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            path = ds.Tables[0].Rows[0]["path"].ToString(); //------save the path in variable
            conn.Close();    
        }

        private void ADDitemBTN_Click(object sender, EventArgs e)
        {           
            try
            {
                int id, qty;
                float total, unitPrice;
                if (!Int32.TryParse(TXTProdID.Text, out id)) { } //-----------Convert ProductID to int Type
                if (!Int32.TryParse(TXTQty.Text, out qty)) { }   //-----------Convert Quantity to int Type
                if (!float.TryParse(TOTALlbl.Text, out total)) { }////--------Convert Total to Float Type
                if (!float.TryParse(TXTUnitPrice.Text, out unitPrice)) { }//--Convert Price to Float Type

                Sales sale = new Sales(); //----------------------------------Creating Sale class Object
                sale.transaction(id, qty, total, unitPrice);//----------------Call "Transaction Func"
                 if(sale.flag_not_enough_item == true || sale.not_available)//If item is unavailable or out of Stock then
                {
                    ERRLBL.ForeColor = LBLitemaddSuccess .ForeColor = Color.Red;
                    ERRLBL.Text = "ERROR!";
                    LBLitemaddSuccess.Text = sale.Message;//------------------Show Error
                    dt.Rows.RemoveAt(dataGridView1.RowCount -2 );//---Delete the last added product in the Bill Datatable
                    dataGridView1.DataSource = dt;//--------------------------Bind the Bill Grid
                    ADDitemBTN.Enabled = false;//-----------------------------Disable add Button
                    double temp =Convert .ToDouble ( dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value );
                     temp = temp - Convert .ToDouble (TOTALlbl .Text );
                     dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = temp;
 
                }
                else
                {
                    LBLitemaddSuccess.ForeColor = Color.LimeGreen;
                    //    ERRLBL.Text = sale.Message;
                    LBLitemaddSuccess.Text = sale.Message;
                    TXTProdID.Text = "";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void TXTProdID_TextChanged(object sender, EventArgs e)
        {                        
            TXTQty.Text = "";
            try
            {
                Product prod = new Product();//-----------------Creating Object of Product Class
                prod.get_Product_Deatails(Convert.ToInt32(TXTProdID.Text));//-------Call ProductDetails Method to Get Product Details
                TXTProdName.Text = prod.Product_Name;
                TXTUnitPrice.Text = prod.Prod_Price;
                TXTManufacturer.Text = prod.Manufacturer;
            }

            catch (Exception ex)
            {
                if(TXTProdID.Text == "")
                {
                    ADDitemBTN.Enabled = false;//-----------------It ProductID TextBox is empty disable the Add Item BUtton
                }
                else
                {
                   
                }
               

            }
        }

        private void TXTUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTQty_TextChanged(object sender, EventArgs e)
        {          
            try
            {
                float price;
                int qty;
                float tot;
                if (!float.TryParse(TXTUnitPrice.Text, out price))//----Convert String type to float Type and if it  is a string then generate the follwong error
                {
                    ERRLBL.Text = "ERROR!";
                    LBLitemaddSuccess.Text = "INVALID PRICE! Try again!";
                }
                if (!Int32.TryParse(TXTQty.Text, out qty))
                {
                   // dt.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    //dataGridView1.DataSource = dt;
                    if (TXTQty.Text != "")// If Quantity in Empty then Generate Error
                    {
                        LBLitemaddSuccess.ForeColor = ERRLBL.ForeColor = Color.Red;
                        ERRLBL.Text = "ERROR!";
                        LBLitemaddSuccess.Text = "INVALID Quantity. Please enter a valid quantity";
                        ADDitemBTN.Enabled = false;                    
                    }
                }
                BTN_OK.Enabled = true;// Enable ok Button
                tot = price * qty;//------Calculate the Total Price
                TOTALlbl.Text = Convert.ToString( tot);  
            }
            catch (Exception ex)
            {
                ERRLBL.Text = "ERROR!";
                LBLitemaddSuccess.Text = ex.Message;  
            }
        }

        private void ClearAllBTN_Click(object sender, EventArgs e)
        {
            //-----------------Clear Form and Bill Grid
            TXTProdID.Text = TXTProdName.Text = TXTManufacturer.Text = TXTUnitPrice.Text = TXTQty.Text = " ";
            dt.Clear();
                       
        }

        private void REMOVEitenBTN_Click(object sender, EventArgs e)
        {            
            try
            {
                //===========Remove the recently added item from the Bill Grind
                TXTProdID.Text = TXTProdName.Text = TXTManufacturer.Text = TXTUnitPrice.Text = TXTQty.Text = " ";
                //dt.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dt.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                ERRLBL.Text = "ERROR!";
                LBLitemaddSuccess.Text = ex.Message;
            }
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            try
            {    //-----------If No. Of Cols is Greater than 0 then Remove the Last grid
                //------------Which is actually a Total's Grid i'e the TOtal Footer Grid
                if (dataGridView1.Rows .Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
                //------Add new row to DataTable then in Bill Grid
                dt.Rows.Add(TXTProdID.Text, TXTProdName.Text, TXTManufacturer.Text, TXTUnitPrice.Text, TXTQty.Text, TOTALlbl.Text);
                dataGridView1.DataSource = dt;
                ADDitemBTN.Enabled = true;
                Double Total = 0.0;
                //-------Show total in Footer
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                }
                dt.Rows.Add("Total", "", "", "", "", Total.ToString());
                dataGridView1.DataSource = dt;
                dataGridView1.Rows[dataGridView1.Rows.Count-1].DefaultCellStyle.BackColor = Color.Gainsboro;                
            }
            catch(Exception ex)
            {
                ERRLBL.Text = "ERROR!";
                LBLitemaddSuccess.Text = ex.Message;
            }
           
        }

        private void allSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            AllSALES all_sale = new AllSALES();
            all_sale.Show();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ALL_PRODUCTS all_prod = new ALL_PRODUCTS();
            all_prod.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void BTN_identify_Click(object sender, EventArgs e)
        {
            try
            {
               // pictureBox1.InitialImage = null;
            
            //int range = 4;
            //Random_NumbersGenerator.Test obj = new Random_NumbersGenerator.Test();
            //MWArray random_number = (MWNumericArray)obj.random_number_generator((MWArray)range);
            //TXTProdID.Text = random_number.ToString();


            //MATLAB_NN_CODE.Class1 obj = new MATLAB_NN_CODE.Class1();
            //MWArray OUT = (MWNumericArray)obj.test();
            //TXTProdID.Text = OUT.ToString();

                //IMSHOW
                //CHKKK.Class1 c = new CHKKK.Class1();
                //MWArray OUT = (MWNumericArray)c.test();
                //TXTProdID.Text = OUT.ToString();

                //camera
                //cam_test.Class1 c = new cam_test.Class1();
                //MWArray OUT = (MWNumericArray)c.test();
                //TXTProdID.Text = OUT.ToString();

                //finalBuild
                //FinalBuild.Class1 c = new FinalBuild.Class1();
                //MWArray OUT = (MWNumericArray)c.test();
                //TXTProdID.Text = OUT.ToString();

                ////testing 15000 epox
                //testing1500epox.Class1 tst = new testing1500epox.Class1();
                //MWArray OUT = (MWNumericArray)tst.test();
                //TXTProdID.Text = OUT.ToString();

                //DLL50000epox.Class1 tst = new DLL50000epox.Class1();
                //MWArray OUT = (MWNumericArray)tst.test();
                //TXTProdID.Text = OUT.ToString();

               // DLL.Class1 tst = new DLL.Class1();
                //MWArray OUT = (MWNumericArray)tst.test();
                //TXTProdID.Text = OUT.ToString();

                //TXTProdID.Text = "";
                //
                //----------------------------------------------------
                //TEST.Class1 tst = new TEST.Class1();
                //MWArray OUT = (MWNumericArray)tst.test();
                //TXTProdID.Text = OUT.ToString();
                //--------------------------------------------------------


                //DLL With PATH
               
                //-----------------------------Calling Matlab Function to Identify The Product
                //testWithPath.Class1 tst = new testWithPath.Class1();
                //MWArray OUT = (MWNumericArray)tst.test((MWArray )path);
                //TXTProdID.Text = OUT.ToString();
                //-----------------------------------------------------------------------------


                //DLL with-------> This is LATESTTTTTTT One
                //LATEST_TestWithPath_LATEST.MyClasss test = new LATEST_TestWithPath_LATEST.MyClasss();
                //MWArray OUT = (MWNumericArray)test.test((MWArray)path);
                //TXTProdID.Text = OUT.ToString();


                //Image image = Image.FromFile("image.jpg");
                // Set the PictureBox image property to this image.
                // ... Then, adjust its height and width properties.
                //pictureBox1.Image = image;
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox1.Height = image.Height;
                //pictureBox1.Width = image.Width;


                //----------------This One is FINAL i am Sure!!!-------------------

                test_FINAL_FINAL.Class1 tst = new test_FINAL_FINAL.Class1();
                MWArray OUT = (MWNumericArray)tst.test();
                TXTProdID.Text = OUT.ToString();


                Image img = GetCopyImage("image.jpg");//------------get the copy of the image and keep it in IMAGE object
                pictureBox1.Image = img;//--------------------------Bind the PictureBox with the IMAGE object
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                File.Delete("image.jpg");//-------------------------Delete the recently captured image so that it can
                                        //--------------------------show the next image when it is captured
                
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yyyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TainingPlotForm objTPF = new TainingPlotForm();
            objTPF.Show();
        }


        private Image GetCopyImage(string path)
        {//-------------------Get the Path of image from argument
            using (Image img = Image .FromFile (path))//-------------Load that image in the Object
            {
                Bitmap bm = new Bitmap(img);//-------//Create the Bitmap
                return bm;//-------------------------Return Bitmap
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//---------------Disable Manual Input in Bill Grid
            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].ReadOnly = false;
            }
        }

       

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
            
        }

        private void newDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CaptureImagesForm objCaptureImagesFrm = new CaptureImagesForm();  
            objCaptureImagesFrm.Show();
        }

        private void trainDatasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ExtFeatureAndTrain obj = new ExtFeatureAndTrain();
            obj.Show();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder objPO = new PurchaseOrder();
            objPO.Show();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delivery objDeliveryFrm = new Delivery();
            objDeliveryFrm.Show();
        }

        private void productWastageManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsWastageManagement objForm = new ItemsWastageManagement();
            objForm.Show ();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRmvSelected_Click(object sender, EventArgs e)
        {
            try
            {

                TXTProdID.Text = TXTProdName.Text = TXTManufacturer.Text = TXTUnitPrice.Text = TXTQty.Text = " ";
                dt.Rows.RemoveAt(dataGridView1.CurrentCell .RowIndex );
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                ERRLBL.Text = "ERROR!";
                LBLitemaddSuccess.Text = ex.Message;
            }

        }

        private void TXTProdID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void TXTQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            ClsPrint objPrint = new ClsPrint(dataGridView1, "Customer Bill");
            objPrint.PrintForm();
        }

        private void DataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesRep obj = new SalesRep();
            obj.Show();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepInventory ri = new RepInventory();
            ri.Show();
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepProduct rp = new RepProduct();
            rp.Show();
        }

        private void wastedItemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepWasted rw = new RepWasted();
            rw.Show();
        }

        private void purchaseOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepPurchase rpu = new RepPurchase();
            rpu.Show();
        }

        private void deliveryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryReport frm = new DeliveryReport();
            frm.Show();
        }
        
    }
}

