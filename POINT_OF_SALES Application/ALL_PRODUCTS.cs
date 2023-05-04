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

namespace POINT_OF_SALES_Application
{
    public partial class ALL_PRODUCTS : Form
    {
        public ALL_PRODUCTS()
        {
            InitializeComponent();
        }

         public void clear ()
        {
            txtManufacturer.Text = txtPrice.Text = txtProdID.Text = txtProdNAme.Text = "";
             }

        private void ALL_PRODUCTS_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Products", conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Delete_Product (Convert.ToInt32(txtProdID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                SqlConnection conn = new SqlConnection("Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True");
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select * from Products", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Add_Product(Convert.ToInt32(txtProdID.Text), txtProdNAme.Text, Convert.ToDouble (txtPrice.Text), txtManufacturer.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                SqlConnection conn = new SqlConnection("Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True");
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select * from Products", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            clear();
        }

        private void txtProdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProdID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Update_Product(Convert.ToInt32(txtProdID.Text), txtProdNAme.Text, Convert.ToDouble(txtPrice.Text), txtManufacturer.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                SqlConnection conn = new SqlConnection("Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True");
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("select * from Products", conn);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
            clear();
        }
    }
}
