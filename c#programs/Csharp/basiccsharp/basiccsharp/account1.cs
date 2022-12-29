using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class account1
    {
        public int acno;
        public string name;
        public string email;
        public string phone;
        //constructor
        public account1(int acno, string name, string email, string phone)
        {
            //member variables
            this.acno = acno;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        public string info()
        {
            return $"Account Number:  {acno}\nName: {name}Email: {email}Phone: {phone}";
        }
        public static void depositAmt()
        {
            int amount = 0, deposit;
            Console.WriteLine("Please Enter Your Account Number");
            int ac1 = Convert.ToInt32(Console.ReadLine());
            if (ac1 == 101)
            {
                Console.WriteLine("Welcome vimala");
                Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                deposit = Convert.ToInt32(Console.ReadLine());
                amount = amount + deposit;
                Console.WriteLine("YOUR BALANCE IS {0}", amount);

            }
            else if (ac1 == 102)
            {
                Console.WriteLine("Welcome Sai");
                Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                deposit = Convert.ToInt32(Console.ReadLine());
                amount = amount + deposit;
                Console.WriteLine("YOUR BALANCE IS {0}", amount);
            }
            else
            {
                Console.WriteLine("Please enter a valid Account Number");
            }
        }

    }
}
