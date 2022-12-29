using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class product
    {
        public int code;
        public string name;
        public string description;
        public string supplier;
        public int price;
        public  string abc()
        {
            return "code:" + code + "name:" + name + "Description" + description + "supplier:" + supplier + "price:" + price;
        }
    }
}
