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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.Hospitals
{
    public partial class patiantDonorAdd : Form
    {
        public patiantDonorAdd()
        {
            InitializeComponent();
        }
        public hospitalView MainHospitalView { get; set; }
        public int hospitalID { get; set; }
        private void patiantDonorAdd_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patients", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.comboBox1.DataSource = dt;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT payment FROM Patients WHERE patiantID=@i", con))
                {
                    cmd.Parameters.AddWithValue("@i", comboBox1.SelectedValue);
                    con.Open();
                    decimal p = (decimal)cmd.ExecuteScalar();
                    con.Close();
                    this.lblpayment.Text = p.ToString("0.00");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                con.Open();
                using (SqlTransaction tran = con.BeginTransaction())
                {

                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO patiantDonors 
                                            (hospitalID, patiantID, timeOfDonation ) VALUES
                                            (@h, @p, @t)", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@h", hospitalID);
                        cmd.Parameters.AddWithValue("@p", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@t", dateTimePicker1.Value);

                        try
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tran.Commit();
                                this.dateTimePicker1.Value=DateTime.Now;

                                con.Close();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tran.Rollback();
                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                        }

                    }
                }

            }
        }

        private void patiantDonorAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainHospitalView.LoadData();
        }
    }
}
