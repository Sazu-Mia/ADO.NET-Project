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

namespace Project.Hospitals
{
    public partial class hospitalView : Form
    {
        DataSet ds = new DataSet();
        BindingSource bshos = new BindingSource();
        BindingSource bspd = new BindingSource();
        public hospitalView()
        {
            InitializeComponent();
        }

        private void hospitalView_Load(object sender, EventArgs e)
        {
            LoadData();
           
            AddRelations();
            BindControls();
        }

        private void AddRelations()
        {
            ds.Tables["hospitals"].PrimaryKey = new DataColumn[] { ds.Tables["hospitals"].Columns["hospitalID"] };
            DataRelation rel = new DataRelation("FK_H_PD",
                ds.Tables["hospitals"].Columns["hospitalID"],
                ds.Tables["patiantDonors"].Columns["hospitalID"]);
            ds.Relations.Add(rel);
        }

        private void BindControls()
        {
            bshos.DataSource = ds;
            bshos.DataMember = "hospitals";
            bspd.DataSource = bshos;
            bspd.DataMember = "FK_H_PD";
            lblid.DataBindings.Add(new Binding("Text", bshos, "hospitalID"));
            lblname.DataBindings.Add(new Binding("Text", bshos, "hospitalName"));
            lbldonor.DataBindings.Add(new Binding("Text", bshos, "donorName"));
            this.dataGridView1.DataSource = bspd;
        }

        public void LoadData()
        {
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables["patiantDonors"].Rows.Count > 0)
                {
                    ds.Tables["patiantDonors"].Rows.Clear();
                }
                if (ds.Tables["hospitals"].Rows.Count > 0)
                {
                    ds.Tables["hospitals"].Rows.Clear();
                }
            }
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT hospitalID, hospitalName, DonorName, phone, d.donorID 
                                                                FROM hospitals h
                                                                INNER JOIN Donors d ON h.donorID = d.donorID", con))
                {

                    da.Fill(ds, "hospitals");
                    da.SelectCommand.CommandText = @"SELECT p.patiantID, patiantName, payment, bloodGroup, timeOfDonation, pd.hospitalID
                                                    FROM patiantDonors pd
                                                    INNER JOIN Patients p ON pd.patiantID = p.patiantID";
                    da.Fill(ds, "patiantDonors");


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bshos.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bshos.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (bshos.Position > 0)
            {
                bshos.MovePrevious();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bshos.Position < bshos.Count - 1)
            {
                bshos.MoveNext();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new hospitalAdd { MainHospitalView = this}.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int hospitalID = int.Parse((bshos.Current as DataRowView).Row["hospitalID"].ToString());
            new patiantDonorAdd { MainHospitalView = this, hospitalID = hospitalID }.ShowDialog();
        }
    }
}
