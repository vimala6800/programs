using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static basiccsharp.list;

namespace basiccsharp
{
    internal class exception
    {
        public static void demo()
        {
            Console.WriteLine("enter a number:");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine("Squre of{0} is {1}", num, num * num);
        }

        public static void demo1()
        {
            try
            {
                Console.WriteLine("enter a number:");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("Squre of{0} is {1}", num, num * num);

            }
            catch
            {
                Console.WriteLine("error occured");
            }
            finally
            {
                Console.WriteLine("retry with a different");
            }
        }
        public static void demo2()
        {
            Console.Write("please enter a number to divide 100:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100 / num;
                Console.WriteLine("100/{0}={1}", num, result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("cannot divide by 0,please try again");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("invalid operation.please try again");

            }
            catch(FormatException)
            {
                Console.WriteLine("not a valid format.please try again");
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occured! please try again");
            }
        }
        public static void demo3()

        {
            var divider = 0;
            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch
                {
                    Console.WriteLine("inner catch");
                }
            }
            catch
            {
                Console.WriteLine("outer exception");
            }
        }
          
        public static void demo4()
        {
            Student std = null;
            var divider = 0;
            try
            {
                try
                {
                    var result =100/divider;
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine("inner catch");
                }
            }
            catch
            {
                Console.WriteLine("outer catch");
            }
        }

    }
    
}
