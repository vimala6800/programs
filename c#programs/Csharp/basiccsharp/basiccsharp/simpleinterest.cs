using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class simpleinterest
    {
        public static void time()
        {
            int time;
            double principle, rate, SI;
            Console.WriteLine("enter loan amount");
            principle=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the time");
            time=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter rate of interest");
            rate=Convert.ToDouble(Console.ReadLine());
            SI = principle * time * rate / 100;
            Console.WriteLine("simple interest is:{0}",SI);
            Console.ReadLine(); 
        }
    }
}
