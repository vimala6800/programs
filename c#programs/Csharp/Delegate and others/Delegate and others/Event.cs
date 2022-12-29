using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegate_and_others.EmployeeSeparator;

namespace Delegate_and_others
{
    class EmployeeSeparator
    {
        public delegate void EmployeeSeparatedEventHandler();
        public event EmployeeSeparatedEventHandler EmployeeSeparated;   
        public void Seperate()
        {
            if(EmployeeSeparated != null)
            {
                EmployeeSeparated();
            }
        }
            
    }

    internal class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;
        public Finance(EmployeeSeparator employeeSeparator)
        {

            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }
        public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("Finanace department:employee separation");
        }
    }
    internal class Event
    {
        internal static void testEvent()
        {
            EmployeeSeparator employeeSeparator = new EmployeeSeparator();  
            Finance finance = new Finance(employeeSeparator);
            employeeSeparator.Seperate();
        }
        
    }
}
