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

namespace QL_Ban_Hang
{
    public partial class frmDmHang : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        string Fname, sql, constr, tmanhom,tmahang,ttenhang,tdvt,tsanxuat,tdgvnd,tdgusd;
        int i, n;
        Boolean addnewflag = false;
        public frmDmHang()
        {
            InitializeComponent();
        }

        private void frmDmHang_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-9TM72T9J;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select MaNhom, MaHH, TenHH, Dvt, SanXuat, Dgvnd, Dgusd From tblDMHH Order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();

            sql = "SELECT * FROM tblDMNhom ";
            da = new SqlDataAdapter(sql, conn);
            dt3.Clear();
            da.Fill(dt3);
            txtMaNhom.DataSource = dt3;
            txtMaNhom.DisplayMember = "TenNhom";
            txtMaNhom.ValueMember = "MaNhom";

            sql = "SELECT * FROM tblDMNuocSX ";
            da = new SqlDataAdapter(sql, conn);
            dt4.Clear();
            da.Fill(dt4);
            txtNuocSX.DataSource = dt4;
            txtNuocSX.DisplayMember = "TenNuocSX";
            txtNuocSX.ValueMember = "MaNuocSX";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)// Lập trình cho nút đầu
        {
            grdData.ClearSelection();
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "Select MaNhom, MaHH, TenHH, Dvt, SanXuat, Dgvnd, Dgusd From tblDMHH "+
                " WHERE " + Fname + "=N'" + comFvalue.Text + "' Order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "Select MaNhom, MaHH, TenHH, Dvt, SanXuat, Dgvnd, Dgusd From tblDMHH Order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void comfname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFname.Text == "Mã nhóm") Fname = "Manhom";
            if (comFname.Text == "Tên hàng") Fname = "TenHH";
            if (comFname.Text == "Nước sản xuất") Fname = "Sanxuat";
            sql = "SELECT DISTINCT " + Fname + " FROM tblDMHH";
            da = new SqlDataAdapter(sql,conn);
            dt2.Clear();
            da.Fill(dt2);
            comFvalue.DataSource = dt2;
            comFvalue.DisplayMember = Fname;
            comFvalue.ValueMember = Fname;
        }

        private void btnLast_Click(object sender, EventArgs e)// Lập trình cho nút cuối
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)// Lập trình cho nút sau
        {
            i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
                NapCT();
            }

        }

        private void btnPrv_Click(object sender, EventArgs e)// Lập trình cho nút trước
        {
            i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa dòng hiện thời ?(Y/N)","Xác nhận yêu cầu",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                sql = "Delete from tblDMHH where MaHH='" + txtMaHang.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);//Xóa dòng hiện thời
                NapCT();                
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            txtMaNhom.Focus();
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                //cap nhat them moi
                sql = "INSERT INTO tblDMHH (MaNhom, MaHH, TenHH, Dvt, SanXuat, Dgvnd, Dgusd) VALUES "
                + "('" + txtMaNhom.SelectedValue + "','" + txtMaHang.Text + "',N'" + txtTenHang.Text + "',"
                + "N'" + txtDVT.Text + "'," + "N'" + txtNuocSX.SelectedValue + "','" + txtDonGia.Text + "',"
                + txtDonGiaUSD.Text + ")";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Naplai();
                MessageBox.Show("Đã thêm mới thành công!");
                addnewflag = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                //cap nhat sua chua
                n = grdData.RowCount - 1;
                for (i = 0; i < n; i++)
                {
                    tmanhom = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
                    ttenhang = grdData.Rows[i].Cells["TenHH"].Value.ToString();
                    tdvt = grdData.Rows[i].Cells["Dvt"].Value.ToString();
                    tdgvnd = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
                    tsanxuat = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
                    tmahang = grdData.Rows[i].Cells["MaHH"].Value.ToString();
                    tdgusd = grdData.Rows[i].Cells["Dgusd"].Value.ToString();
                    sql = "UPDATE tblDMHH SET TenHH=N'" + ttenhang + "',dvt= N'" + tdvt + "',"
                        + "Sanxuat =N'" + tsanxuat + "',Dgvnd =" + tdgvnd + ",Dgusd =" + tdgusd
                        + " WHERE MaHH = '" + tmahang + "'"; //Quan trong phai co WHERE
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công mọi sự sửa đổi!");
                btnUpdate.Enabled = false;
            }
        }

        public void NapCT()
        {
             int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
             txtMaNhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
             txtTenHang.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
             txtDVT.Text = grdData.Rows[i].Cells["Dvt"].Value.ToString();
             txtDonGia.Text = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
             txtNuocSX.Text = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
             txtMaHang.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
             txtDonGiaUSD.Text = grdData.Rows[i].Cells["Dgusd"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi trên ô lưới, kết thúc ấn nút Cập nhật");
            grdData.Focus();
        }

        public void Naplai()
        {
            sql = "Select MaNhom, MaHH, TenHH, Dvt, SanXuat, Dgvnd, Dgusd From tblDMHH Order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
        }

}
}
