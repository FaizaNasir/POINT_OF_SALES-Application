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
    public partial class ItemsWastageManagement : Form
    {
        public ItemsWastageManagement()
        {
            InitializeComponent();
        }

        private void ItemsWastageManagement_Load(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";

            conn.Open();

            SqlCommand com = new SqlCommand("select *from Products", conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cboWastedProd.DisplayMember = ds.Tables[0].Columns["ProductName"].ToString();
            cboWastedProd.ValueMember = ds.Tables[0].Columns["ProdID"].ToString();
            cboWastedProd.DataSource = ds.Tables[0];
        }

        private void QtyWasted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void QtyWasted_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            DataTable dt = new DataTable();
            string query = "select Rate from PurchaseOrder where ProdID = '" + cboWastedProd.SelectedValue + "' and IsLatest = 1";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            adp.Fill(dt);
            txtPORate.Text = dt.Rows[0]["Rate"].ToString();

            txtLoss.Text = ( Convert .ToDouble  (txtPORate.Text) * Convert.ToInt32(QtyWasted .Text )).ToString ();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
              bool flag_not_enough_item, not_available;
              string QTY_IN, QTY_OUT, wasted_Qty_Out;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter("select ProdID from Inventory where ProdID = '" + cboWastedProd .SelectedValue  + "'", conn);
            DataSet ds= new DataSet();
            adp.Fill(ds, "Inventory");
            if (ds.Tables[0].Rows.Count == 0)
            {
                //not_available = true;
                MessageBox .Show( "This item is currently not available in inventory");
                return;
            }
            adp = new SqlDataAdapter("select sum(isNUll(Qty_In,0)) as QTY_IN,sum(isNUll(Qty_Out,0)) as QTY_OUT,sum(isNUll(Wasted_Qty_Out,0)) as WASTED_QTY_OUT from Inventory where ProdID = '" + cboWastedProd.SelectedValue + "'", conn);
           adp.Fill(ds, "Inventory");

           QTY_IN = ds.Tables["Inventory"].Rows[ds.Tables["Inventory"].Rows.Count - 1]["QTY_IN"].ToString();
           QTY_OUT = ds.Tables["Inventory"].Rows[ds.Tables["Inventory"].Rows.Count - 1]["QTY_OUT"].ToString();
           wasted_Qty_Out = ds.Tables["Inventory"].Rows[ds.Tables["Inventory"].Rows.Count - 1]["WASTED_QTY_OUT"].ToString();

                      

            if (Convert.ToInt32(QTY_IN) - (Convert.ToInt32(QTY_OUT) + Convert .ToInt32 (wasted_Qty_Out )) < Convert .ToInt32 ( QtyWasted .Text ))
            {
                //flag_not_enough_item = true;
                MessageBox .Show ( "Not enough Quantity in stock");
                return;
            }


            if (Convert.ToInt32(QTY_OUT) + Convert.ToInt32(wasted_Qty_Out ) != Convert.ToInt32(QTY_IN))
            {
                
                string query = "select * from Inventory";
                 adp= new SqlDataAdapter(query, conn);
                SqlCommandBuilder builInv = new SqlCommandBuilder(adp);
                adp.Fill(ds, "Inventory");
                DataRow dr= ds.Tables["Inventory"].NewRow();
                dr["ProdID"] = cboWastedProd .SelectedValue ;
                dr["Wasted_Qty_Out"] = Convert .ToInt32 ( QtyWasted .Text) ;
                dr["Rate"] = Convert .ToDouble( txtPORate .Text );
                dr["Cash_Out"] = Convert .ToDouble( txtLoss .Text );
                dr["Date_Wasted"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ds.Tables["Inventory"].Rows.Add(dr);
                adp.Update(ds, "Inventory");

                
                query = "select * from WastedProducts";
                adp= new SqlDataAdapter(query, conn);
                //DataSet dsWasted  = new DataSet();
                SqlCommandBuilder builWasted = new SqlCommandBuilder(adp);
                adp.Fill(ds, "WastedProducts");
                dr= ds.Tables["WastedProducts"].NewRow();
                dr["ProdID"] = cboWastedProd .SelectedValue ;
                dr["QuantityWasted"] = Convert .ToInt32 ( QtyWasted .Text );
                dr["Loss"] = Convert .ToDouble ( txtLoss .Text );
                ds.Tables["WastedProducts"].Rows.Add(dr);
                adp.Update(ds, "WastedProducts");


                MessageBox .Show ( "Item added successfully!");
            }
            else
            {
                MessageBox .Show ( "This Item is out of stock");
            }

            //DataRow dr = ds.Tables["Sales"].NewRow();
            //dr["ProdID"] = prdID;
            //dr["Quantity"] = qty;
            //dr["SaleTotal"] = sale_total;
            //ds.Tables["Sales"].Rows.Add(dr);
            //adp.Update(ds, "Sales");
            //  status = "Added Successfully";


           

        }
    }
}
