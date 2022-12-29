using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class methodoverloading
    {
        public int add(int n1,int n2)
        {
            return n1 + n2;
        }
        public float add(float n1,float n2)
        {
            return n1 + n2;
        }
        public double add(double n1, double n2)
        {
            return n1 + n2;

        }
    }
}
