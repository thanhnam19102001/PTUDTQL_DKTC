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
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        string sql, constr;
        int i;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-8NPS3NGO; Initial Catalog = DKTC; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from SINHVIEN where MASV ='" + txtTk.Text + "' and MATKHAU = '" + txtMk.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                if (txtTk.Text == "11190220"  ) 
                { MessageBox.Show("Đăng nhập thành công với tư cách là admin!"); this.Hide();
                    Form f = new frmAdmin();
                    f.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Đăng nhập thành công với tư cách là user!"); this.Hide();
                    Form f = new frmMain();
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

    }
}

