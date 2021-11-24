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
    public partial class frmAdmin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        string sql, constr, Fname, Fvalue;
        int i;
        DataTable datarpt = new DataTable();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            if (comFname.Text =="Mã môn")
            {
                rptDKHP rpt = new rptDKHP();
                sql = "select MAMON, MAHP, TENMON, SOTC, GIANGVIEN, LICHHOC, PHONGHOC, SOLUONGSV, HOCPHI " +
                    "From viewDKHP" + " where MAMON='" + comFvalue.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                datarpt.Clear();
                da.Fill(datarpt);
                rpt.SetDataSource(datarpt);
                rpt.DataDefinition.FormulaFields["MAMON"].Text = "'" + comFvalue.Text + "'";
                rptDKTCpreview rp = new rptDKTCpreview(rpt);
                rp.Show();
              
            }    
        }
    }
}
