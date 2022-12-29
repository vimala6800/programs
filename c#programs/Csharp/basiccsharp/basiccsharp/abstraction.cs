using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal abstract class shape
    {
        public abstract void draw();
        public void info()
        {
            Console.WriteLine("i am shape:abstract class");
        }
        
    }

    internal class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("circle is draw");
        }
        public void othershape()
        {
            Console.WriteLine("other shape");
        }
    }
    internal class abstraction
    {
        public static void  testabstractclass()


            {
            // shape shape= new shape();
            shape s = new circle();
             
            s.draw();
            s.info();

            circle c = new circle();
            c.othershape();

            }

    }
}
