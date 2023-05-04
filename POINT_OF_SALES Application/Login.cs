using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;  

namespace POINT_OF_SALES_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid User Name!");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter a valid Password!");
                textBox2.Focus();
            }
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
                con.Open();
                string userid = textBox1.Text;
                string password = textBox2.Text;
                SqlCommand cmd = new SqlCommand("select UserName,Password from Login where UserName='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   // MainForm   myForm1 = new MainForm();
                    Form1 myForm1 = new Form1();
                //    MessageBox.Show("Login successful Welcome to Homepage");
                    this.Hide();
                    myForm1.Show();


                }
                else
                {
                    MessageBox.Show("Invalid Login please check Username or Password");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void BTNSignUP_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignupForm sign = new SignupForm();
            sign.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            ws w = new ws();
            w.Show();
        }

    }
}

