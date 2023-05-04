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
    public partial class AllSALES : Form
    {
        public AllSALES()
        {
            InitializeComponent();
        }

        private void AllSALES_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("select Sales.SaleID, Products.ProdID , Products.ProductName, Products.ProductPrice, Sales.Quantity,Sales.SaleTotal from Sales Inner join Products on Sales.ProdID = Products.ProdID;", conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
