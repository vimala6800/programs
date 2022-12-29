using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class ProjectManager
    {
        [Key]
        public int PMId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public long Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Pincode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
