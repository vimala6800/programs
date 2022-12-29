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

namespace wct2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {

                    string nam = Name.Text;
                    int mat = Convert.ToInt32(Matches.Text);
                    int wo = Convert.ToInt32(Won.Text);
                    int los = Convert.ToInt32(Lost.Text);
                    int point = Convert.ToInt32(Points.Text);

                    string query = "insert into wct20222 values(@name,@matches,@won,@lost,@points)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", nam);
                    cmd.Parameters.AddWithValue("@matches", mat);
                    cmd.Parameters.AddWithValue("@won", wo);
                    cmd.Parameters.AddWithValue("@lost", los);
                    cmd.Parameters.AddWithValue("@points", point);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();

                    if (status > 0)
                    {
                        result.Text = "data has been inserted sucessfully";
                    }
                    else
                    {
                        result.Text = "data insertion is failed";
                    }




                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Wct20222_Load(object sender, EventArgs e)
        {

        }
    }
}
    

