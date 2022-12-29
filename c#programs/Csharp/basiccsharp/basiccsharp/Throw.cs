using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static basiccsharp.list;

namespace basiccsharp
{
    internal class Throw
    {
        public class Student
        {

            public string StudentName { get; set; }
        }
        public static void demo()
        {
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null. ");

            Console.WriteLine(std.StudentName);
        }
        public static void demo1()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }

        public static void Method2()
        {
            string str = null;
            try
            {
                Console.Write(str[0]);
            }
            catch (NullReferenceException ex)
            {
                throw;
            }

        }
        public static void demo2()
        {
            try
            {
                Method3();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        public static void Method3()
        {
            try
            {
                Method4();
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        public static void Method4()
        {
            string str = null;
            try
            {
                Console.Write(str[0]);
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }


    }
   

}


