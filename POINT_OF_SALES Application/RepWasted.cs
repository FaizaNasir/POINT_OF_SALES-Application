using CrystalDecisions.CrystalReports.Engine;
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
    public partial class RepWasted : Form
    {
        public RepWasted()
        {
            InitializeComponent();
        }

        private void RepWasted_Load(object sender, EventArgs e)
        {

        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {

         

        }

        private void getReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepWasted w = new RepWasted();
            w.Show();
            //ReportDocument crystalReport = new ReportDocument();
            //crystalReport.Load(@"D:\FYP Work\POINT_OF_SALES Application\POINT_OF_SALES Application\ReportWasted.rpt");
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";
            //string DateFrom = datefrom.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            //string DateTo = dateto.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            //string Qry = "exec WasredProduct @DateWastedFrom ='" + DateFrom + "' , @DateWastedTo = '" + DateTo + "'";
            //SqlDataAdapter adp = new SqlDataAdapter(Qry, conn);
            //DataSet ds = new DataSet();                           //Dataset
            //adp.Fill(ds, "WastedProducts");

            //crystalReport.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
