using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetbasis
{
    internal class BasicCRUD
    {
        internal static SqlConnection GetConnection()
        {
            string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection has beeen successfully created");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //con.Close();
            }
            return con;
        }
        internal static void ReadData()
        {
            string query = "select * from product";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("ProductId:" + dr[0] + "ProductName:" + dr[1] + "SupplierId:" + dr[2] + "CategoryId:" + dr[3] + "Unit:" + dr[4] + "Price:" + dr[5]);
            }
            conn.Close();
        }
        internal static void InsertData()
        {
            string query = "insert into product values (10,'TV',106,6,'20c*15b',60000)";
            SqlConnection conn = GetConnection();
            SqlCommand cmd= new SqlCommand(query,conn);
           // SqlDataReader dr = cmd.ExecuteReader();
            int status=cmd.ExecuteNonQuery();
            if(status>0)
            {
                Console.WriteLine("Insertion Sucessful");
            }
            else
            {
                Console.WriteLine("Insertion failed");
            }
            conn.Close();
        }
        internal static void UpdateData()
        {
            Console.WriteLine("Update Data");
            Console.WriteLine("Enter ProductName to update price");
            string ProductName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter updated price");
            decimal Price=Convert.ToDecimal(Console.ReadLine());
            string query = "update product set Price=@Price where ProductName=@ProductName";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //int status = cmd.ExecuteNonQuery();
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Price", Price);
            int status1 = cmd.ExecuteNonQuery();
             
            if (status1 > 0)
            {
                Console.WriteLine("Updated sucessful");
            }
            else 
            {
                Console.WriteLine("updation failed");
            }
            conn.Close();
        }
        internal static void DeleteData()
        {
            Console.WriteLine("Delete Data");
            Console.WriteLine("Enter Price to delete Product Name");
            decimal Price = Convert.ToDecimal(Console.ReadLine()); 
            Console.WriteLine("Enter deleted product name");
            string ProductName = Convert.ToString(Console.ReadLine());
            string query = "delete product set  ProductName=@ProductName where  Price=@Price";
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //int status = cmd.ExecuteNonQuery();
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            int status2 = cmd.ExecuteNonQuery();
            if (status2 > 0)
            {
                Console.WriteLine("Deletion sucessful");
            }
            else
            {
                Console.WriteLine("Deletion failed");
            }
            conn.Close();
        }
    }
    
}
