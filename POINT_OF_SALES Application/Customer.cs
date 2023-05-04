using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALES_Application
{
    class Customer
    {
        public string Cust_ID;
        string Customer_Name;
        public string status = null;

        public void set_Customer_Name(string name)
        {


            Customer_Name = name;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            DataTable dt = new DataTable();
            string query = "select * from Customers";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            SqlCommandBuilder buil = new SqlCommandBuilder(adp);
            adp.Fill(dt);
            for (int rows = 0; rows < dt.Rows.Count; rows++)
            {
                if (dt.Rows[rows]["CustomerName"].ToString() == Customer_Name)
                {
                    status = "Customer already exists";
                    Cust_ID = dt.Rows[rows]["CustID"].ToString();
                }

            }
            if (status != "Customer already exists")
            {
                DataSet ds = new DataSet();
                adp.Fill(ds, "Customers");
                DataRow dr = ds.Tables["Customers"].NewRow();
                dr["CustomerName"] = Customer_Name;
                ds.Tables["Customers"].Rows.Add(dr);
                adp.Update(ds, "Customers");
                status = "Added Successfully";
            }

        }

    }

}
