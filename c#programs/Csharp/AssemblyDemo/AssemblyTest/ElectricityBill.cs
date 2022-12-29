using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTest
{
    internal class ElectricityBill
    {


        public double calculateBill(int units)
        {
            if (units <= 100)
            {
                return units * 1;
            }
            else if (units > 100 && units <= 200)
            {
                return 100 * 1 + (units - 100) * 2;
            }
            else if (units > 200 && units <= 300)
            {
                return (100 * 1) + (100 * 2) + (units - 200) * 3;
            }
            else
                return (100 * 1) + (100 * 2) + (100 * 3) + (units - 300) * 5;

        }
        public void reference()
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("Class : {0}", item.Name);
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("--> Method : {0}", method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                            arg.Name, arg.ParameterType);
                    }
                }


            }
        }

    }
}

