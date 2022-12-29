using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class convert
    {
        public static void currency()
        {
            Console.WriteLine("Enter the amount in American dollars :");
            float INR = Convert.ToInt32(Console.ReadLine());
            var dollar = INR / 80;
            Console.WriteLine(+dollar + "INR");
        }
        public static void currency1()
        {
            Console.WriteLine("Enter the amount in euro:");
            float INR = Convert.ToInt32(Console.ReadLine());
            var Euro = INR / 10;
            Console.WriteLine(+Euro + "INR");
        }
    }
}
