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
    public partial class frmLichsu : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        string sql, constr;
        int i;
        public frmLichsu()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa dòng hiện thời ?(Y/N)", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from DSDK where MAMON='" + txtMAMON.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);//Xóa dòng hiện thời
                NapCT();
            }
        }

        private void frmLichsu_Load(object sender, EventArgs e)
        {

                constr = "Data Source=LAPTOP-9TM72T9J;Initial Catalog=DKTC;Integrated Security=True";
                conn.ConnectionString = constr;
                conn.Open();
                sql = " Select MAMON, MALHP, DSMH, DSTC, DSGV, DSHP from  DSDK " +
                    " order by MAMON ";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdData.DataSource = dt;
                grdData.Refresh();
                NapCT();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.ClearSelection();
            grdData.CurrentCell = grdData[0, 0];
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

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        public void NapCT()
        {
            if (grdData.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa đăng ký học phần nào");
                btnDel.Enabled = false;
            }
            else
            {
                i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
                txtMAMON.Text = grdData.Rows[i].Cells["MAMON"].Value.ToString();
                txtMALHP.Text = grdData.Rows[i].Cells["MALHP"].Value.ToString();
                txtTENMON.Text = grdData.Rows[i].Cells["DSMH"].Value.ToString();
                txtSOTC.Text = grdData.Rows[i].Cells["DSTC"].Value.ToString();
                txtGIANGVIEN.Text = grdData.Rows[i].Cells["DSGV"].Value.ToString();
                txtHOCPHI.Text = grdData.Rows[i].Cells["DSHP"].Value.ToString();
            }
        
        }
    }
 }
