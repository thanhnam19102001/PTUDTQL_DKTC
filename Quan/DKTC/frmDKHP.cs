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
    public partial class frmDKHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        Boolean flag = false;

        string sql, constr, Fname, tMamon, tMaLhp, tTenmon, tSotc, tLichhoc, tPhonghoc, tGiangvien, tSoluong;
        int i;

        public frmDKHP()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void grdData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnDk_Click(object sender, EventArgs e)
        {
            
            
                sql = " Insert into tblDSDK (MAMON, MASV, DSMH, DSGV, DSTC, DSHP)  values "
                    + "('" + txtMAMON.Text + "','" + frmLogin.userID + "',N'" + txtTENMON.Text + "'," + "N'" + txtGIANGVIEN.Text + "','" + txtSOTC.Text + "','" + txtHOCPHI.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng ký thành công");
        }

        

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "Select * From viewDKHP " +
                " WHERE " + Fname + "=N'" + comFvalue.Text + "' Order by MALHP";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();

        }

        private void frmDKHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-8NPS3NGO; Initial Catalog = DKTC; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MAMON, MALHP, TENMON, SOTC, LICHHOC, PHONGHOC, GIANGVIEN, SOLUONGSV from  viewDKHP " +  
                " order by MALHP ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
            
            
            
            

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.ClearSelection();
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
                NapCT();
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
        }

        private void comFname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFname.Text == "Mã môn") Fname = "MAMON";
            if (comFname.Text == "Mã lớp học phần") Fname = "MALHP";
            if (comFname.Text == "Tên môn") Fname = "TENMON";
            sql = "Select distinct " + Fname + " From  viewDKHP ";
            da = new SqlDataAdapter(sql, conn);
            dt2.Clear();
            da.Fill(dt2);
            comFvalue.DataSource = dt2;
            comFvalue.DisplayMember = Fname;
            comFvalue.ValueMember = Fname;


        }

        public void NapCT()
        {
            i = grdData.CurrentRow.Index ;//lấy số thứ tự dòng hiện thời
            txtMAMON.Text = grdData.Rows[i].Cells["MAMON"].Value.ToString();
            txtMALHP.Text = grdData.Rows[i].Cells["MALHP"].Value.ToString();
            txtTENMON.Text = grdData.Rows[i].Cells["TENMON"].Value.ToString();
            txtSOTC.Text = grdData.Rows[i].Cells["SOTC"].Value.ToString();
            txtLICHHOC.Text = grdData.Rows[i].Cells["LICHHOC"].Value.ToString();
            txtPHONGHOC.Text = grdData.Rows[i].Cells["PHONGHOC"].Value.ToString();
            txtGIANGVIEN.Text = grdData.Rows[i].Cells["GIANGVIEN"].Value.ToString();
            txtSOLUONGSV.Text = grdData.Rows[i].Cells["SOLUONGSV"].Value.ToString();
        }
    }
}
