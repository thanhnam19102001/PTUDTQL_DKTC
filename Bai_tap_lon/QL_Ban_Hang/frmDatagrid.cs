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
    public partial class frmDatagrid : Form
    {
        public frmDatagrid()
        {
            InitializeComponent();
        }

        private void frmDatagrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.tblDMHH' table. You can move, or remove it, as needed.
            this.tblDMHHTableAdapter.Fill(this.qLBHDataSet.tblDMHH);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MoveNext();
        }
    }
}
