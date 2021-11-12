using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Ban_Hang
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmHello();
           toolStripStatusLabel1.Text = "Hello World!";
            f.ShowDialog();
            toolStripStatusLabel1.Text = "Ready!";
        }

        private void cộngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmBT1();
            f.ShowDialog();
        }

        private void máyTínhBỏTúiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmCal();
            f.ShowDialog();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form f = new frmHello();
            f.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoigian.Text = System.DateTime.Now.ToString();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDmHang();
            f.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

