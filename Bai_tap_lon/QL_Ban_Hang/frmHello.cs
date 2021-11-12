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
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Chao mung ban den voi lap trinh C# ";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblHello.Text = ""; 
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.Aqua;
            btnShow.Font = new Font(btnShow.Font.FontFamily, 10);
            btnShow.ForeColor = Color.Red;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.Lavender;
            btnShow.Font = new Font(btnShow.Font.FontFamily, 8);
            btnShow.ForeColor = Color.Black;
        }

        private void btnHide_MouseHover(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.Aqua;
            btnHide.Font = new Font(btnShow.Font.FontFamily, 10);
            btnHide.ForeColor = Color.Red;
        }

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.Lavender;
            btnHide.Font = new Font(btnShow.Font.FontFamily, 8);
            btnHide.ForeColor = Color.Black;
        }
    }
}
