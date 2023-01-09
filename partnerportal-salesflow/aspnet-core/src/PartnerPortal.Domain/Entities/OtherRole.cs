using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Domain.Entities
{
    public class OtherRole
    {
        [Key]
        public Guid ORId { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string Photo { get; set; }
        public Guid UserId { get; set; }
    }
}
