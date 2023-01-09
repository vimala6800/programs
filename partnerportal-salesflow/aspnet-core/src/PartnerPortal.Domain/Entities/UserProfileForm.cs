using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Domain.Entities
{
    public class UserProfileForm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public IFormFile Image { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Password { get; set; }

    }
}
