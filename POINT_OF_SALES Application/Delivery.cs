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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";

            conn.Open();

            SqlCommand com = new SqlCommand("select * from PurchaseOrder where IsClosed = 0 ", conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboPurchaseOrder.DisplayMember = ds.Tables[0].Columns["POName"].ToString();
            cboPurchaseOrder.ValueMember = ds.Tables[0].Columns["PoID"].ToString();
            cboPurchaseOrder.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void cboPurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            conn.Open();
            SqlCommand com = new SqlCommand("select * from PurchaseOrder PO join Products P on(P.ProdID = PO.ProdID ) where IsClosed = 0 and PO.PoID = '" + cboPurchaseOrder.SelectedValue + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            txtProductName.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
            txtPORate.Text = ds.Tables[0].Rows[0]["Rate"].ToString();
            txtManufacturer.Text = ds.Tables[0].Rows[0]["Manufacturer"].ToString();
            txtQtyOrderd.Text = ds.Tables[0].Rows[0]["Qty"].ToString();
            conn.Close();
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
                conn.Open();
                SqlCommand comPO = new SqlCommand("select * from PurchaseOrder PO join Products P on(P.ProdID = PO.ProdID ) where IsClosed = 0 and PO.PoID = '" + cboPurchaseOrder.SelectedValue + "'", conn);
                SqlDataAdapter adp = new SqlDataAdapter(comPO);
                DataSet ds = new DataSet();
                adp.Fill(ds, "PurchaseOrder");


                string query = "select * from Inventory";
                adp = new SqlDataAdapter(query, conn);
                SqlCommandBuilder buil = new SqlCommandBuilder(adp);
                adp.Fill(ds, "Inventory");
                DataRow dr = ds.Tables["Inventory"].NewRow();
                dr["ProdID"] = ds.Tables["PurchaseOrder"].Rows[0]["ProdID"];
                dr["Qty_In"] = txtQty_Delivered.Text;
                dr["Rate"] = Convert.ToDouble(txtDeliveryRate.Text);
                dr["Cash_Out"] = Convert.ToInt32(txtDeliveryRate.Text) * Convert.ToInt32(txtQty_Delivered.Text);
                dr["Transaction_Date"] = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                ds.Tables["Inventory"].Rows.Add(dr);
                adp.Update(ds, "Inventory");

                query = "select * from Delivery";
                adp = new SqlDataAdapter(query, conn);
                buil = new SqlCommandBuilder(adp);
                adp.Fill(ds, "Delivery");
                dr = ds.Tables["Delivery"].NewRow();
                dr["POID"] = cboPurchaseOrder.SelectedValue;
                dr["ProdID"] = ds.Tables["PurchaseOrder"].Rows[0]["ProdID"]; ;
                dr["Rate"] = Convert.ToDouble(txtDeliveryRate.Text);
                dr["Manufacturer"] = ds.Tables["PurchaseOrder"].Rows[0]["Manufacturer"];
                dr["Qty"] = txtQty_Delivered.Text;
                dr["Date_Delivered"] = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                ds.Tables["Delivery"].Rows.Add(dr);
                adp.Update(ds, "Delivery");


                SqlCommand comPO_IsClosed = new SqlCommand("update PurchaseOrder set IsClosed = 1 where PoID = '" + cboPurchaseOrder.SelectedValue + "'", conn);
                comPO_IsClosed.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Delivery record added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox .Show (ex.Message );
            }

        }
    }

}
