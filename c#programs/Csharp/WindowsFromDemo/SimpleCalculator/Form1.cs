using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int res = 0;
            int n1 = Convert.ToInt32(num1.Text);
            string oper = opr.Text;
            int n2 = Convert.ToInt32(num2.Text);
            if (oper == "+")
            {
                res = n1 + n2;
            }
            else if (oper == "-")
            {
                res = n1 - n2;
            }
            else if (oper == "*")
            {
                res = n1 * n2;
            }
            else if (oper == "/")
            {
                res = (n1 / n2);
            }
            else
            {
                res = -1;
            }
            result.Text = res.ToString();
        }

    }
}

