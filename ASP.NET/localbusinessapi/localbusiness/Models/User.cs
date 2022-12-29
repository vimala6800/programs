using System;
using System.Collections.Generic;

namespace localbusiness.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string City { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Zipcode { get; set; }
        public string Pasword { get; set; } = null!;
        public int Roleid { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
