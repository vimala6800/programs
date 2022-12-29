using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class RBI
    {
        public float roi = 0f;
        public float rateofinterest()
        {
            roi = 2.5f;
            return roi;
        }
    }
    internal class SBI : RBI
    {
        public float rateofinterest()
        {
            roi = 5f;
            return roi;
        }
    }

    internal class HDFC : RBI
    {

        public float rateOfInterest()
        {
            roi = 7F;
            return roi;
        }

        internal class methodoverride
        {
            public static void testmethodoverride() 
            {
               
                RBI rbi = new SBI();
                float rate = rbi.rateofinterest();
                Console.WriteLine(" SBI rateofinterest" + rate);
                rbi = new HDFC();
                rate = rbi.rateofinterest();
                Console.WriteLine("HDFC rate of interest" + rate);
                //rbi.info()

            }
        }                                   

    }
}
