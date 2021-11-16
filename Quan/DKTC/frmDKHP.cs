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
        string sql, constr;
        int i;

        public frmDKHP()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmDKHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-8NPS3NGO; Initial Catalog = DKTC; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from viewDKHP ";
            da = new SqlDataAdapter(sql, conn);
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

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        public void NapCT()
        {
            int i = grdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMamon.Text = grdData.Rows[i].Cells["MAMON"].Value.ToString();
            txtMalhp.Text = grdData.Rows[i].Cells["MALHP"].Value.ToString();
            txtTenmon.Text = grdData.Rows[i].Cells["TENMON"].Value.ToString();
            txtSotc.Text = grdData.Rows[i].Cells["SOTC"].Value.ToString();
            txtLh.Text = grdData.Rows[i].Cells["LICHHOC"].Value.ToString();
            txtPh.Text = grdData.Rows[i].Cells["PHONGHOC"].Value.ToString();
            txtGv.Text = grdData.Rows[i].Cells["GIANGVIEN"].Value.ToString();
            txtSlsv.Text = grdData.Rows[i].Cells["SOLUONGSV"].Value.ToString();
        }
    }
}
