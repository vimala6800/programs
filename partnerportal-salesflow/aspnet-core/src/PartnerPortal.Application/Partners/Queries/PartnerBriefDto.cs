using PartnerPortal.Application.Common.Mappings;
using PartnerPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Application.Partners.Queries
{
    public class PartnerBriefDto:IMapFrom<Partner>,IMapFrom<Country>,IMapFrom<Skill>
    {
        public Guid PartnerID { get; set; }
        public string PartnerName { get; set;}
        public string Location { get; set;}
        public string Country { get; set;}
        public Guid CountryID { get; set;}
        public DateTime RegisteredDate { get; set;}
        public string Address1 { get; set;}
        public string BillingAddress1 { get; set;}
        public int PartnerStatus { get; set;}
        public Guid SkillID { get; set; }
        public string SkillName { get; set;}    
        public string? SPOCName { get; set;}
        public Guid? SPOCUserID { get; set;}
        public string? SPOCEmail { get; set;}
       

    }
}
