using Project.Donors;
using Project.Hospitals;
using Project.Patients;
using Project.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new patientView { MdiParent= this }.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new patientAdd { MdiParent= this }.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new patientEdit { MdiParent= this }.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new donorAdd { MdiParent= this }.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new donorView { MdiParent= this }.Show();
        }

        private void editDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new donorEdit { MdiParent= this }.Show();
        }

        private void hospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new hospitalView { MdiParent= this }.Show();
        }

        private void simpleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportForm1 { MdiParent= this }.Show();
        }

        private void groupReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportForm2 { MdiParent= this }.Show();
        }

        private void reportWithImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportForm3 { MdiParent= this }.Show();
        }
    }
}
