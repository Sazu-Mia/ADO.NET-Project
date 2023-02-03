using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project.Patients
{
    public partial class patientAdd : Form
    {
        string pictureName = "";
        public patientAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                this.pictureName = this.openFileDialog1.FileName;
            }
        }

        private void patientAdd_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = GetPatientsId().ToString();
        }
        private int GetPatientsId()
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(patiantID), 0) FROM Patients", con))
                {
                    con.Open();
                    int id = (int)cmd.ExecuteScalar();
                    con.Close();
                    return id + 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(dbConnectionHelper.ConStr))
            {
                con.Open();
                using (SqlTransaction tran = con.BeginTransaction())
                {

                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Patients 
                                            (patiantID, patiantName, bloodGroup, patiantAddress, Payment, picture) VALUES
                                            (@i, @n, @b, @a, @p, @pic)", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@i", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@n", textBox2.Text);
                        cmd.Parameters.AddWithValue("@b", textBox3.Text);
                        cmd.Parameters.AddWithValue("@a", textBox4.Text);
                        cmd.Parameters.AddWithValue("@p", textBox5.Text);
                        string ext = Path.GetExtension(this.pictureName);
                        string fileName = $"{Path.GetFileNameWithoutExtension(Path.GetRandomFileName())}{ext}";
                        string savePath = Path.Combine(Path.GetFullPath(@"..\..\Pictures"), fileName);
                        File.Copy(pictureName, savePath, true);
                        cmd.Parameters.AddWithValue("@pic", fileName);

                        try
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tran.Commit();
                                this.textBox1.Clear();
                                this.textBox2.Clear();
                                this.textBox3.Clear();
                                this.textBox4.Clear();
                                pictureBox1.Image = null;
                                pictureName = "";
                                con.Close();
                                this.textBox1.Text = GetPatientsId().ToString();
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
    }
}
