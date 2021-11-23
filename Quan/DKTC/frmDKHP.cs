using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
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
        string sql, constr, Fname;
        int i;

        public frmDKHP()
        {
            InitializeComponent();
        }

        private void btnDk_Click(object sender, EventArgs e)
        {
            int b;
            //Kiểm tra đã đăng ký môn này hay chưa
            sql = "select count (*) from DSDK where MASV= '" + frmLogin.userID + "' and DSMH = N'" + txtTENMON.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt4.Clear();
            da.Fill(dt4);
            var c = dt4.Rows[0][0];
            int d = Int16.Parse(c.ToString());
            if (d == 0)
            {
                sql = "Select count(*) from MONTIENQUYET where MAMONTQ in (select MAMON from DSDK where MASV = '" + frmLogin.userID +"')";
                da = new SqlDataAdapter(sql, conn);
                dt4.Clear();
                da.Fill(dt4);
                var h = dt4.Rows[0][0];
                int g = Int16.Parse(h.ToString());
                //Thao tác đăng ký
                sql = " Insert into DSDK (MAMON, MASV, MALHP,DSMH, DSGV, DSTC, DSHP)  values "
                + "('" + txtMAMON.Text + "','" + frmLogin.userID + "','"+ txtMALHP.Text + "',N'" + txtTENMON.Text + "'," + "N'" + txtGIANGVIEN.Text + "','" + txtSOTC.Text + "','" + txtHOCPHI.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = "select SUM (DSTC) from DSDK where MASV ='" + frmLogin.userID + "'";
                da = new SqlDataAdapter(sql, conn);
                dt3.Clear();
                da.Fill(dt3);
                var a = dt3.Rows[0][0];
                b = Int16.Parse(a.ToString());
                //Kiểm tra số tín chỉ đã vượt ngưỡng hay chưa?
                if (b > 3)                    
                {
                    MessageBox.Show("Bạn đã đăng ký vượt quá số tín chỉ quy định!, vui lòng xóa học phần để có thể đăng ký học phần này");
                    Form f = new frmLichsu();
                    f.ShowDialog();
                }
                else
                {
                  MessageBox.Show("Bạn đã đăng ký thành công" );
                }
            }
            else
            {
                MessageBox.Show("Bạn đã đăng ký môn học này! " );
            }


        }

        private void grdData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
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
            constr = "Data Source=LAPTOP-9TM72T9J;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MAMON, MALHP, TENMON, SOTC, LICHHOC, PHONGHOC, GIANGVIEN, SOLUONGSV, HOCPHI from  viewDKHP " +  
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
            txtHOCPHI.Text = grdData.Rows[i].Cells["HOCPHI"].Value.ToString();
        }
    }
}
