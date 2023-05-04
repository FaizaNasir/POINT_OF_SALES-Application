using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALES_Application
{
    

    class Product
    {
        int ProductID;
        public string Product_Name, Prod_Price, Manufacturer;
        public int total;
        


       public void get_Product_Deatails(int ID)
        {
            ProductID = ID;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            DataTable dt = new DataTable();
            string query = "select * from Products where ProdID = '" +ProductID  + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            
            adp.Fill(dt); 
            Product_Name = dt.Rows[0]["ProductName"].ToString();
            Prod_Price = dt.Rows[0]["ProductPrice"].ToString();
            Manufacturer = dt.Rows[0]["Manufacturer"].ToString();
            //total = Convert.ToInt32(dt.Rows[0]["ProductPrice"]) * QTY;
        }

        public void Add_Product(int ID, string ProdName,double  Price, string Manufacturer)
       {
           SqlConnection conn = new SqlConnection();
           conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
           string query = "select * from Products";
           SqlDataAdapter  adp = new SqlDataAdapter(query, conn);
           DataSet ds = new DataSet();
           SqlCommandBuilder builInv = new SqlCommandBuilder(adp);
           adp.Fill(ds, "Products");
           DataRow dr = ds.Tables["Products"].NewRow();
           dr["ProdID"] = ID;
           dr["ProductName"] = ProdName;
           dr["ProductPrice"] = Price;
           dr["Manufacturer"] = Manufacturer;
           ds.Tables["Products"].Rows.Add(dr);
           adp.Update(ds, "Products");
       }

        public void Update_Product(int ID, string ProdName, double Price, string Manufacturer)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            conn.Open();
            //SqlCommand comPO_IsClosed = new SqlCommand("d= '" ++ "'", conn);
            string qry = "update Products set ProductName = '" + ProdName + "',ProductPrice = '" + Price + "',Manufacturer = '" + Manufacturer + "' where ProdID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(qry,conn );
            cmd.ExecuteNonQuery();

            conn.Close();
        }



        public void Delete_Product(int ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            conn.Open();
            //SqlCommand comPO_IsClosed = new SqlCommand("update PurchaseOrder set IsClosed = 1 where PoID = '" + cboPurchaseOrder.SelectedValue + "'", conn);
            SqlCommand cmd = new SqlCommand("Delete from Products where ProdID= '" + ID+ "'", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
