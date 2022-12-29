using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGNUPFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string email = Email.Text;
            long mob = Convert.ToInt64(Mobile.Text);
            string sex;
            if (Sex1.Checked==true)
            {
                sex = Sex1.Text;
            }
            else
            {
                sex= Sex2.Text;
            }
            string d = dob.Text;
            string l=Location.Text;
            result.Text = "Name:  " + name + "\nEmail:   " + email + "\nMobile:  " + mob + "\nSex:  " + sex + "\ndob:    " + d + "\nLocation:   " + l;
        }
    }
}
