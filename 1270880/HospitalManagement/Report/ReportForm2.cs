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

namespace Project.Report
{
    public partial class ReportForm2 : Form
    {
        public ReportForm2()
        {
            InitializeComponent();
        }

        private void ReportForm2_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Donors", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Donors");
                    da.SelectCommand.CommandText = "SELECT * FROM Patients";
                    da.Fill(ds, "Patients");
                    da.SelectCommand.CommandText = "SELECT * FROM hospitals";
                    da.Fill(ds, "hospitals");
                    da.SelectCommand.CommandText = "SELECT * FROM patiantDonors";
                    da.Fill(ds, "patiantDonors");
                    Report2 rpt = new Report2();
                    rpt.SetDataSource(ds);
                    this.crystalReportViewer1.ReportSource= rpt;
                    this.crystalReportViewer1.Refresh();
                }
            }
        }
    }
}
