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
    public partial class frmBT1 : Form
    {
        int i, n, t;
        public frmBT1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            i = 0;
            while (i<=n)
            {
                t = t + i;
                i += 2;
            }
            lblKQ.Text = "Tổng các số chẵn trong " + txtN.Text + " số tự nhiên đầu tiên tính theo cách 2 là: " + Convert.ToString(t);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            i = 0;
            do
            {
                t = t + i;
                i += 2;
            }
            while (i <= n);
            lblKQ.Text = "Tổng các số chẵn trong " + txtN.Text + " số tự nhiên đầu tiên tính theo cách 3 là: " + Convert.ToString(t);
        }

        private void frmBT1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            for (i=0; i<=n; i+=2)
            {
                t = t + i;
            }
            lblKQ.Text = "Tổng các số chẵn trong " + txtN.Text + " số tự nhiên đầu tiên tính theo cách 1 là: " + Convert.ToString(t); 
        }
    }
}
