using System;
using System.Collections.Generic;

namespace localbusiness.Models
{
    public partial class Service
    {
        public Service()
        {
            ServicebookingServices = new HashSet<Servicebooking>();
            ServicebookingUsers = new HashSet<Servicebooking>();
            Serviceproviders = new HashSet<Serviceprovider>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual ICollection<Servicebooking> ServicebookingServices { get; set; }
        public virtual ICollection<Servicebooking> ServicebookingUsers { get; set; }
        public virtual ICollection<Serviceprovider> Serviceproviders { get; set; }
    }
}
