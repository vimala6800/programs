using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BulkyBook.Models
{
    public class Project
    {
        [ Key]
        public int PId { get; set; }
        [Required]
        [Display(Name = "Customers")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [ValidateNever]
        public  Customer Customer{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "ProjectManager")]
        public int ProjectManagerId { get; set; }
        [ValidateNever]
        public   ProjectManager ProjectManager { get; set; }

        public DateTime ProposalSubmissionDate { get; set; }

        public String Status { get; set; }
    }
}


