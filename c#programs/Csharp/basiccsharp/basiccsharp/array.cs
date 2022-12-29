using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class array
    {
        public static void arrays()
        {
            string[] colors = { "red", "green", "pink", "orange" };
            Console.WriteLine("looping");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            Console.WriteLine("update");
            colors[0] = "white";
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Array.Sort(colors);


            Console.WriteLine("After sort");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("runs array of int");
            int[] runs = new int[5];
            runs[0] = 25;
            runs[1] = 20;
            runs[2] = 44;
            runs[3] = 60;
            runs[4] = 30;
            foreach (int run in runs)
            {
                Console.WriteLine(run);
            }
            int max = runs.Max();
            Console.WriteLine("maximum - " + max);

            int min = runs.Min();
            Console.WriteLine("mininum - " + min);
            int total = runs.Sum();
            Console.WriteLine("total - " + total);

            Array.Sort(runs);
            Console.WriteLine("After sort");

            foreach (int run in runs)
            {
                Console.WriteLine(run);
            }
        }
    }
    
}
