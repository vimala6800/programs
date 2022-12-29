using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_others
{
    public delegate void AnonymousDeelgate(int n1);
    public delegate int MyDelegate(int n1, int n2);
    public delegate int MathsDelegate(int num);
    internal class anonymouslamda
    {
        internal static void AnonymousDemo()
        {
            AnonymousDeelgate amd = delegate (int a)
            {
                a += 10;
                Console.WriteLine("Anonymous Function" + a);
            };
            amd(10);
            MyDelegate obj = (a, b) => a + b;
            int sum = obj.Invoke(100, 200);
            Console.WriteLine("AnonymousDemo:Lamda:Sum is" + sum);

            MathsDelegate mdSQR = (num) => num * num;
            int sqr = mdSQR(3);
            Console.WriteLine("SQUARE of {0} is {1}", 3, sqr);

            MathsDelegate mdCUBE = (num) => num * num * num;
            int cube = mdSQR(3);
            Console.WriteLine("SQUARE of {0} is {1}", 3, cube);
            Console.WriteLine("Delegate as parameter");
            DelegateASParam(delegate (int a)
                {
                    a += 10;
                    Console.WriteLine("delegate" + a);
                    return a;
                }, 5);
        }
             internal static void DelegateASParam(MathsDelegate mathDel, int num)
            {
                num += 10;
                mathDel.Invoke(num);
            }
            
                


            
        }
    }

