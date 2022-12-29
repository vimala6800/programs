using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class conversion
    {
        public static void kms()
        {
            Console.WriteLine(" enter the distance in km");
            int km = Convert.ToInt32(Console.ReadLine());
            var miles = km * 0.609344f;
            Console.WriteLine(miles);



        }
    }
}
