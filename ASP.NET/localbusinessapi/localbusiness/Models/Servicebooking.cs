using System;
using System.Collections.Generic;

namespace localbusiness.Models
{
    public partial class Servicebooking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Serviceid { get; set; }
        public int Userid { get; set; }
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int Serviceproviderid { get; set; }
        public string Providerdescription { get; set; } = null!;

        public virtual Service Service { get; set; } = null!;
        public virtual Serviceprovider Serviceprovider { get; set; } = null!;
        public virtual Service User { get; set; } = null!;
    }
}
