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
    public enum Opration
    {
        None, Cong, Tru, Nhan, Chia
    }
    public partial class frmCal : Form
    {
        double ketqua;
        double hientai;
        bool flag;
        bool secondNum;
        Opration op;
        public frmCal()
        {
            InitializeComponent();
            ketqua = 0;
            flag = true;
            secondNum = false;
            op = Opration.None;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if(lblKQ.Text == "0")
            {
                return;
            }
            if(flag == true)
            {
                lblKQ.Text += "0";
            }
            else
            {
                lblKQ.Text = "0";
            }
            flag = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "2";
            }
            else
            {
                lblKQ.Text = "2";
            }
            flag = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "3";
            }
            else
            {
                lblKQ.Text = "3";
            }
            flag = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "1";
            }
            else
            {
                lblKQ.Text = "1";
            }
            flag = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "4";
            }
            else
            {
                lblKQ.Text = "4";
            }
            flag = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "5";
            }
            else
            {
                lblKQ.Text = "5";
            }
            flag = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "6";
            }
            else
            {
                lblKQ.Text = "6";
            }
            flag = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "7";
            }
            else
            {
                lblKQ.Text = "7";
            }
            flag = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "8";
            }
            else
            {
                lblKQ.Text = "8";
            }
            flag = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "0")
            {
                lblKQ.Text = "";
            }
            if (flag == true)
            {
                lblKQ.Text += "9";
            }
            else
            {
                lblKQ.Text = "9";
            }
            flag = true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            ketqua = ketqua + Convert.ToDouble(lblKQ.Text);
            flag = false;
            lblKQ.Text = String.Format("{0}", ketqua);
            secondNum = true;
            op = Opration.Cong;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (secondNum == false)
            {
                ketqua = Convert.ToDouble(lblKQ.Text);
            }
            else
            {
                ketqua = ketqua - Convert.ToDouble(lblKQ.Text);
            }
            flag = false;
            lblKQ.Text = String.Format("{0}", ketqua);
            secondNum = true;
            op = Opration.Tru; 
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (op == Opration.Cong)
            {
                ketqua = ketqua + Convert.ToDouble(lblKQ.Text);
            }
            else if (op == Opration.Tru)
            {
                ketqua = ketqua - Convert.ToDouble(lblKQ.Text);
            }
            else if (op == Opration.Nhan)
            {
                ketqua = ketqua * Convert.ToDouble(lblKQ.Text);
            }
            else if (op == Opration.Chia)
            {
                ketqua = ketqua / Convert.ToDouble(lblKQ.Text);
            }
            lblKQ.Text = String.Format("{0}", ketqua);
            flag = false;
            secondNum = false;
            ketqua = 0;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (secondNum == false)
            {
                ketqua = Convert.ToDouble(lblKQ.Text);
            }
            else
            {
                ketqua = ketqua * Convert.ToDouble(lblKQ.Text);
            }
            flag = false;
            lblKQ.Text = String.Format("{0}", ketqua);
            secondNum = true;
            op = Opration.Nhan;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (secondNum == false)
            {
                ketqua = Convert.ToDouble(lblKQ.Text);
            }
            else
            {
                ketqua = ketqua / Convert.ToDouble(lblKQ.Text);
            }
            flag = false;
            lblKQ.Text = String.Format("{0}", ketqua);
            secondNum = true;
            op = Opration.Chia;
        }

        private void frmCal_Load(object sender, EventArgs e)
        {

        }
    }
}
