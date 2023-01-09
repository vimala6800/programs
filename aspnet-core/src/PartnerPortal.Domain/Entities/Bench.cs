using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Domain.Entities
{
    public class Bench : BaseAuditableEntity
    {
        [Key]
        public Guid BenchID { get; set; }
        public Guid PartnerID { get; set; }
        public int NoOfResource { get; set; }
        public string yearsOfExperience { get; set; }
        public string SkillSet { get; set; }
        public double RatePerHrUSD { get; set; }

    }
}
