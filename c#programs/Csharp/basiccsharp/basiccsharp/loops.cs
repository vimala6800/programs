using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class loops
    {
        public static void whileloop()
        {
            Console.WriteLine("while - print 2's table");
            int start = 2;
            int end = 20;
            while (start <= end)
            {
                Console.WriteLine(start);
                //start = start + 2;
                start += 2;
            }
        }

        public static void forloop()
        {
            Console.WriteLine("for - print 5's table");
            int start = 5;
            int end = 50;
            for (int i = start; i <= end; i = i + 5)
            {
                Console.WriteLine(i);

            }
        }
        public static void forloopbreak()
        {
            Console.WriteLine("for - print 5's table- break n continue");
            int start = 5;
            int end = 50;
            Console.WriteLine("break after printing 10");
            for (int i = start; i <= end; i = i + 5)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break;

            }

            Console.WriteLine("continue without printing 25");
            for (int i = start; i <= end; i = i + 5)
            {

                if (i == 25)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
    
}
