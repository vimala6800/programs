using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class constructor
    {
        int id;
        string name;
        string email;
        string mobile;
        string city;

        public string country { get; set; }

        public int zipcode{get; set; }    
        public constructor(int id, string name,string email,string mobile,string city)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
            this.city = city;

        }
        public string info()
        {
            return $"id:{id} \nname:{name} \nemail:{email} \nmobile:{mobile} \ncity:{city}";
        }
    }
}
