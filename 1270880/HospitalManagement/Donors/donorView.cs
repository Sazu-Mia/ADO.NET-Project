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

namespace Project.Donors
{
    public partial class donorView : Form
    {
        public donorView()
        {
            InitializeComponent();
        }

        private void donorVies_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Donors", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;

                }
            }
        }
    }
}
