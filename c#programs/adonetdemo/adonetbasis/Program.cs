using adonetbasis;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Console.WriteLine("ADO .NET");
        //Connection();
        BasicCRUD.ReadData();
        //BasicCRUD.InsertData();
        // BasicCRUD.UpdateData();
       //BasicCRUD.DeleteData();

    }
    static void Connection()
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
            con.Close();
        }
    }
}