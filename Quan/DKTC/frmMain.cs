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

namespace DKTC
{
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào " + frmLogin.userID);
        }

        private void trangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmLogin();
            f.ShowDialog();
        }

        private void đăngKýHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDKHP();
            f.ShowDialog();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmLogin();
            f.ShowDialog();
        }

        private void txtMSV_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
