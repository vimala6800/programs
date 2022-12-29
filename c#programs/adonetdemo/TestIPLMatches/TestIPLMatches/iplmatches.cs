using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Identity.Client;
using System.Text.RegularExpressions;
using System.IO;

namespace TestIPLMatches
{
    internal class iplmatches
    {

        public static void Connection()
        {
            string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
          
            SqlConnection con = new SqlConnection(cs);
            Console.WriteLine("selct option");
            int choice;
            do
            {
                Console.WriteLine("Press 1  add player\nPress 2  display match\nPress 3  play  match\nPress 4  delete  player\nPress 5 purple cap\npress 6 orangecap\npress 7  exit");
                Console.Write(" Enter your value: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddData();
                        break;
                    case 2:
                        DisplayMatch();
                        break;
                    case 3:
                        PlayMatch();
                        break;
                    case 4:
                        DeletePlayer();
                        break;
                    case 5:
                        purplecap();
                        break;
                    case 6:
                        orangecap();
                        break;
                }
            } while (choice != 7);
        }

        public static void AddData()
            {
                string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
                
                SqlConnection con = new SqlConnection(cs);
                try
                {
                    con = new SqlConnection(cs);
                    Console.WriteLine("enter player name");
                    string name = Console.ReadLine();
                    int matches = 0;
                    Console.WriteLine("no.of matches" + matches);
                    int runs = 0;
                    Console.WriteLine("no.of runs" + runs);
                    int wickets = 0;
                    Console.WriteLine("no.of wickets" + wickets);

                    string query = "insert into iplplayer values(@name,@matches,@runs,@wickets)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@matches", matches);
                    cmd.Parameters.AddWithValue("@runs", runs);
                    cmd.Parameters.AddWithValue("@wickets", wickets);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();

                    if (status > 0)
                    {
                        Console.WriteLine("insertion of details is sucessful");
                    }
                    else
                    {
                        Console.WriteLine("insertion is failed");
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




            public static void DisplayMatch()
            {

                string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
                SqlConnection con = null;
                try
                {
                    using (con = new SqlConnection(cs))
                    {

                        string query1 = "select * from iplplayer";
                        con = new SqlConnection(cs);
                        SqlCommand cmd = new SqlCommand(query1, con);
                        con.Open();
                        SqlDataReader dR = cmd.ExecuteReader();

                        while (dR.Read())
                        {
                            Console.WriteLine($"playerid : {dR[0]} Name : {dR[1]} matches : {dR[2]} runs : {dR[3]} wickets : {dR[4]}");
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
            public static void PlayMatch()
            {
                string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
                SqlConnection con = null;
                try
                {
                    using (con = new SqlConnection(cs))
                    {
                        Console.WriteLine("Enter matchid");
                        int maid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter playerid");
                    int plid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter match date");
                    DateTime madate=Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter location");
                    string loca=Console.ReadLine();
                    Console.WriteLine("Enter runs");
                    int runs=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter wickets");
                    int wick=Convert.ToInt32(Console.ReadLine());
                    

                    string query = "insert into iplmatches values(@maid,@plid,@madate,@loca,@runs,@wick)";
                    string quer= "update iplplayer set runs=runs+@runs,wickets=wick+@wick where playerid=@plid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@maid", maid);
                    cmd.Parameters.AddWithValue("@plid", plid);
                    cmd.Parameters.AddWithValue("@madate", madate);
                   
                    cmd.Parameters.AddWithValue("@loca", loca);
                    cmd.Parameters.AddWithValue("@runs", runs);
                    cmd.Parameters.AddWithValue("@wick", wick);

                    SqlCommand cmd1 = new SqlCommand(quer, con);
                    
                    cmd1.Parameters.AddWithValue("@plid", plid);
                    cmd1.Parameters.AddWithValue("@runs", runs);
                    cmd1.Parameters.AddWithValue("@wick", wick);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    int status1 = cmd1.ExecuteNonQuery();
                   


                    if (status > 0)
                        {
                            Console.WriteLine("updation of details is sucessful");
                        }
                        else
                        {
                            Console.WriteLine("updation is failed");
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
       

           public static void DeletePlayer()
         {
            
                string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
                SqlConnection con = null;

            try
            {
                con = new SqlConnection(cs);
                using (con = new SqlConnection(cs))
                {

                    Console.WriteLine("Enter playerid to delete:");
                    int id = Convert.ToInt32(Console.ReadLine());
                   
                    
                    string query = "delete from iplmatches where playerid=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
             
                    int status = cmd.ExecuteNonQuery();
                    query = "delete from iplplayer where playerid=@id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    
                    status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        Console.WriteLine("Player deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Deletion failed");
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
        public static void purplecap()
        {
            string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    string query = " ";
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
        public static void orangecap()
        {
            string cs = "Data Source=FWS-LP-1012\\SQLSERVER2019;Initial Catalog=demodb;Integrated Security=true;";
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
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




            }
    
}
