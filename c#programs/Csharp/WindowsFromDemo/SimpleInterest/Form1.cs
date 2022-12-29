using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt32(principle.Text);
            double R = Convert.ToDouble(roi.Text);
            int T = Convert.ToInt32(time.Text);
            double s1 = (P * R * T) / 100;
            silb1.Text = Convert.ToString(s1);

        }
    }
}
