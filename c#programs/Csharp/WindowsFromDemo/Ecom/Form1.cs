using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int discount;
            double netamount;
            double result;
            double result1;
            int amt = Convert.ToInt32(purchaseamount.Text);
            if (amt <= 10000)
            {
                if (prime.Checked == true)

                {
                    discount = 10 + 5;
                }
                else
                    discount = 10;
            }
            else if (amt > 10000 && amt <= 20000)
            {
                if (prime.Checked == true)
                {
                    discount = 20 + 5;
                }
                else
                discount = 20;
            }
            else if(amt > 20000 && amt<=30000)
            {
                if (prime.Checked == true)
                {
                    discount = 30 + 5;
                }
                else
                discount=30;
            }
            else
                discount = 30;

            
           result1 = (amt*discount)/100;
            netamount = amt - result1;

            PurchaseAmount1.Text=amt.ToString();
            Discount.Text=result1.ToString();
            NetAmount.Text = netamount.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
        }
    

