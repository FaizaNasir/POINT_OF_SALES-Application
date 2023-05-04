﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class RepInventory : Form
    {
        public RepInventory()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }


      
        private void RepInventory_Load(object sender, EventArgs e)
        {

        }

        private void getReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RepInventory r = new RepInventory();
            r.Show();
            

        }

        private void getProfitLossStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(@"D:\FYP Work\POINT_OF_SALES Application\POINT_OF_SALES Application\ReportInvent-ProfitLoss.rpt");
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SHCOMPUTER-PC;Initial Catalog=POSdb;Integrated Security=True";


            string Qry = "exec rpt_InventoryProfitLoss";
            SqlDataAdapter adp = new SqlDataAdapter(Qry, conn);
            DataSet ds = new DataSet();                           //Dataset
            adp.Fill(ds);

            crystalReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
