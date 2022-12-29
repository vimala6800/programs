using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class printingtable
    {

        public static void table()
        {
            Console.WriteLine("enter the value ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(+num + "*" + i + "=" + i * num);
                i++;
            }
        }
    }
} 
