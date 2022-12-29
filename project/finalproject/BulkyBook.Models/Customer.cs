﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Customer
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Location { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }

    }
}
