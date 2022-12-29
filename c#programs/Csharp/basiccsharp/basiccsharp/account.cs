using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class account
    {
        public int accountno;
        public string name;
        public string email;
        public string mobile;
        public float balance = 0;


        public account(int accountno, string name, string email, string mobile, float balance)
        {
            this.accountno = accountno;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.balance = balance;

        }
        public string info()
        {
            return $"\nAccount number:{this.accountno} \nName :{this.name} \nEmail :{this.email} \nMobile :{this.mobile} \nBalance :{this.balance}";

        }
        public float Deposit(int accountno, float depositamt)
        {
            this.accountno=accountno;
            this.balance=this.balance+depositamt;
            return this.balance;
        }
        
    }
}

