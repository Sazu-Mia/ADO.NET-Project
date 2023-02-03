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
    public partial class hospitalAdd : Form
    {
        public hospitalAdd()
        {
            InitializeComponent();
        }
        public hospitalView MainHospitalView { get; set; }
      
        private void hospitalAdd_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.GetHospitalId().ToString();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Donors", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.comboBox1.DataSource = dt;
                }
            }
        }

        private int GetHospitalId()
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(hospitalID), 0) FROM hospitals", con))
                {
                    con.Open();
                    int id = (int)cmd.ExecuteScalar();
                    con.Close();
                    return id + 1;
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

                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO hospitals 
                                            (hospitalID, hospitalName, donorID ) VALUES
                                            (@i, @n, @d)", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@i", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@n", textBox1.Text);
                        cmd.Parameters.AddWithValue("@d", comboBox1.SelectedValue);





                        try
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tran.Commit();
                                this.textBox1.Clear();
                                this.textBox2.Clear();
                                con.Close();
                                this.textBox1.Text = GetHospitalId().ToString();
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

        private void hospitalAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MainHospitalView.LoadData();
        }
    }
}
