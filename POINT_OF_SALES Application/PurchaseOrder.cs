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
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
           
            conn.Open();

            SqlCommand com = new SqlCommand("select *from Products", conn); 
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  

            cboProducts.DisplayMember  = ds.Tables[0].Columns["ProductName"].ToString(); 
            cboProducts.ValueMember  = ds.Tables[0].Columns["ProdID"].ToString();        
            cboProducts.DataSource = ds.Tables[0];
            
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            int ProdID;
            string Manufacturer;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
                DataTable dt = new DataTable();
                string query = "select * from Products where ProdID = '" + cboProducts.SelectedValue + "'";
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);

                adp.Fill(dt);
                ProdID = Convert.ToInt32(dt.Rows[0]["ProdID"].ToString());
                Manufacturer = dt.Rows[0]["Manufacturer"].ToString();

                string query2 = "select * from PurchaseOrder";
                SqlDataAdapter adp2 = new SqlDataAdapter(query2, conn);
                DataSet ds = new DataSet();
                SqlCommandBuilder buil = new SqlCommandBuilder(adp2);
                //conn.Open();
                //SqlCommand comPO_IsClosed = new SqlCommand("update PurchaseOrder set IsClosed = 0 where ProdID = '" + cboProducts.SelectedValue + "'", conn);
                //comPO_IsClosed.ExecuteNonQuery();

                ///conn.Close();

                adp2.Fill(ds, "PurchaseOrder");
                DataRow dr = ds.Tables["PurchaseOrder"].NewRow();
                dr["ProdID"] = ProdID;
                dr["POName"] = txtPoName.Text;
                dr["Rate"] = Convert.ToDecimal(txtRate.Text);
                dr["Manufacturer"] = Manufacturer;
                dr["Qty"] = Convert.ToInt32(txtQty.Text);
                dr["IsClosed"] = 0;
                dr["IsLatest"] = 1;
                dr["PO_Date"] = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                ds.Tables["PurchaseOrder"].Rows.Add(dr);
                adp2.Update(ds, "PurchaseOrder");
                MessageBox.Show("Purchase Order posted Successfully!");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            DataTable dt = new DataTable();
            string query = "select * from Products where ProdID = '" + cboProducts.SelectedValue + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            adp.Fill(dt);
            txtRetailPrice .Text = dt.Rows[0]["ProductPrice"].ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
    }
}
