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
    public partial class SignupForm : Form
    {
        bool valid_input = true;

        public SignupForm()
        {
            InitializeComponent();
            maskedTextBoxContct.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBoxContct_MaskInputRejected);
            
        }

        private void maskedTextBoxContct_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void maskedTextBoxContct_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
               MessageBox.Show("invalid");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBoxUName.Text = maskedTextBoxPassword.Text = maskedTextBoxContct.Text = maskedTextBoxConfirmPW.Text = maskedTextBoxCNIC.Text = maskedTextBoxAddress.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            
            bool user_already_exists = false;
            if (maskedTextBoxPassword.Text != maskedTextBoxConfirmPW.Text)
            {
                MessageBox.Show("Password and Confirm Passwords do not match");
            }
           
            {
                try
                {

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
                    DataTable dt = new DataTable();
                    string query = "select * from LoginTable";
                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder buil = new SqlCommandBuilder(adp);
                    adp.Fill(dt);
                    for (int rows = 0; rows < dt.Rows.Count; rows++)
                    {
                        if (dt.Rows[rows]["UserName"].ToString() == maskedTextBoxUName.Text)
                        {
                            MessageBox.Show("User already exists");
                            user_already_exists = true;
                            break;
                            //Cust_ID = dt.Rows[rows]["CustID"].ToString();
                        }

                    }
                  
                    maskedTextBoxUName.Text = maskedTextBoxPassword.Text = maskedTextBoxContct.Text = maskedTextBoxConfirmPW.Text = maskedTextBoxCNIC.Text = maskedTextBoxAddress.Text = " ";
                    //if(maskedTextBoxContct.MaskCompleted && maskedTextBoxCNIC.MaskCompleted && maskedTextBoxUName.Text != " " && maskedTextBoxPassword.Text != " " && maskedTextBoxConfirmPW.Text != " ")
                    //{
                    //    MessageBox.Show("enter valid inputs");
                    //}
                     if (user_already_exists == false )
                    {



                        DataSet ds = new DataSet();
                        adp.Fill(ds, "LoginTable");
                        DataRow dr = ds.Tables["LoginTable"].NewRow();
                        dr["UserName"] = maskedTextBoxUName.Text;
                        dr["Password"] = maskedTextBoxPassword.Text;
                        dr["Contact"] = maskedTextBoxContct.Text;
                        dr["CNIC"] = maskedTextBoxCNIC.Text;
                        dr["Address"] = maskedTextBoxAddress.Text;
                        ds.Tables["LoginTable"].Rows.Add(dr);
                        adp.Update(ds, "LoginTable");
                        MessageBox.Show("User added Successfully!");
                        Login log = new Login();
                        this.Hide();
                        log.Show();
                    }
                    //MessageBox.Show("Enter Valid User");
                }
                

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login log = new Login();
            log.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        

        private void SignupForm_Load(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBoxUName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBoxConfirmPW_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
