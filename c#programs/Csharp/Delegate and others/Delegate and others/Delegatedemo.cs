using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_others
{
    public delegate int Calculate(int n1,int n2);
    internal class Calculator
    {
        public  static int add(int n1,int n2)
        {
            return n1 + n2;
        }
        public static int sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int mul(int n1,int n2)
        {
            return n1 * n2;
        }
        public  int div(int n1 ,int n2)
        {
            return n1 / n2;
        }
    }
    internal class Delegatedemo
    {
        public static void DemoDelegate()
        {
            int result = 0;
            /* result = Calculator.add(10, 20);
             Console.WriteLine("regular method call:result of addition:" +result);
             Calculate calc = new Calculate(Calculator.add);
             result = calc.Invoke(10, 20);
             Console.WriteLine("delegate method call:result of addition:" +result);

             result = Calculator.sub(30, 20);
             Console.WriteLine("regular method call:result of subtration:" + result);
             Calculate calc1 = new Calculate(Calculator.sub);
             result = calc1.Invoke(30, 20);
             Console.WriteLine("delegate method call:result of subtration:" + result);

             Calculate cal=new Calculate(Calculator.mul);
             result = cal.Invoke(10, 2);
             Console.WriteLine("delegate method:result of multiplication:" + result);

             Calculator ca1 = new Calculator();

             Calculate ca = new Calculate(ca1.div);
             result = ca.Invoke(30, 5);
             Console.WriteLine("delegate method:result of division:" + result);*/

          
            Console.WriteLine("Multicast delegate:");
            Calculate calc = new Calculate(Calculator.add);
            calc += Calculator.sub;
            int result1 = calc(100, 10);
            Console.WriteLine("Result: " + result1);

        }
            

        
    }
}
