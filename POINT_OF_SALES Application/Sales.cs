using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALES_Application
{
    class Sales
    {
         public string Message;
         public  bool flag_not_enough_item, not_available;
        public void transaction(int prdID, int qty, float sale_total, float unitPrice)
        {
            string QTY_IN, wasted_Qty_Out, QTY_OUT;  //------------------Item wasted, Items In Stock, Items Sold
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            SqlDataAdapter adp = new SqlDataAdapter("select ProdID from Inventory where ProdID = '" + prdID + "'", conn);//Select the Product from INV
            DataSet ds = new DataSet();                           //Dataset
            adp.Fill(ds, "FindProdInventory");                    //Fill DS  
            if (ds.Tables["FindProdInventory"].Rows.Count == 0)   //If Item is Unavailable
            {
                not_available = true;                             //True Flag Item not Available
                Message = "This item is currently not available in inventory";
                
                return;
            }

            //-------------Sum Up QTY_IN, QTY OUT, QTY_WASTED
            adp = new SqlDataAdapter("select sum(isNUll(Qty_In,0)) as QTY_IN,sum(isNUll(Qty_Out,0)) as QTY_OUT,sum(isNUll(Wasted_Qty_Out,0)) as WASTED_QTY_OUT from Inventory where ProdID = '" + prdID + "'", conn);
           //SqlCommandBuilder buil = new SqlCommandBuilder(adp);          
            adp.Fill(ds, "Inventory_SUM");


            //----------------Save Sums in respective Variable
            QTY_IN = ds.Tables["Inventory_SUM"].Rows[ds.Tables["Inventory_SUM"].Rows.Count - 1]["QTY_IN"].ToString();
            QTY_OUT = ds.Tables["Inventory_SUM"].Rows[ds.Tables["Inventory_SUM"].Rows.Count - 1]["QTY_OUT"].ToString();
            wasted_Qty_Out = ds.Tables["Inventory_SUM"].Rows[ds.Tables["Inventory_SUM"].Rows.Count - 1]["WASTED_QTY_OUT"].ToString();

            //----------------Check total QTY in Stock, If it is not less than demanded QTY
            if (Convert.ToInt32(QTY_IN) - (Convert.ToInt32(QTY_OUT) + Convert .ToInt32 (wasted_Qty_Out )) < qty) 
            {
                flag_not_enough_item = true; //-----------If True then Not Enough Item in stock
                Message = "Not enough Quantity in stock";
                conn.Open();
                SqlCommand InV_IsClosed = new SqlCommand("update Inventory set IsClosed = 'True' where ProdID = '" + prdID + "'", conn);
                InV_IsClosed.ExecuteNonQuery();
                conn.Close();
                return;
            }
            
            //----------------Check if QTY wasted + QTY SOLD is not equal QTY in Stock 
            //---------------To check if item is out of stock and must not be sold or added in inventory table as QTY_OUT
            if (Convert.ToInt32(QTY_OUT) + Convert.ToInt32(wasted_Qty_Out) != Convert.ToInt32(QTY_IN)) //If TRUE then
            {
                //========Add the Item/Items in INventory table as Sold Item (QTY_Out)
                string query = "select * from Inventory"; 
                adp = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builInv = new SqlCommandBuilder(adp );
                adp.Fill(ds, "Inventory");
                DataRow dr= ds.Tables["Inventory"].NewRow();
                dr["ProdID"] = prdID;
                dr["Qty_Out"] = qty;
                dr["Rate"] = unitPrice;
                dr["Cash_In"] = sale_total;
                dr["Transaction_Date"] = DateTime.Now.ToString("yyyy-MM-dd  00:00:00");
                ds.Tables["Inventory"].Rows.Add(dr);
                adp.Update(ds, "Inventory");

                //========Also add the item in "SALES" Table to keep track of all sales
                query = "select * from Sales";
                adp= new SqlDataAdapter(query, conn);
                SqlCommandBuilder builSales= new SqlCommandBuilder(adp);
                adp.Fill(ds, "Sales");
                dr = ds.Tables["Sales"].NewRow();
                dr["ProdID"] = prdID;
                dr["Quantity"] = qty;
                dr["SaleTotal"] = sale_total;
                dr["Date_Sold"] = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                ds.Tables["Sales"].Rows.Add(dr);
                adp.Update(ds, "Sales");
                Message = "Item added successfully!";
            }
            else //------------------If item is Finished then Show the Following message
            {
                //SqlCommand InV_IsClosed = new SqlCommand("update Inventory set IsClosed = 1 where ProdID = '" + prdID + "'", conn);
                Message = "This Item is out of stock";
            }
        }
    }
}
