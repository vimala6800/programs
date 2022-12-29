using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
	public class ProjectDetail
	{
        public int Id { get; set; }



        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string JobTitle { get; set; }
        public string SkillSet { get; set; }
        public int Experience { get; set; }
        public int NumberOfMonths { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfResources { get; set; }
        public long MQuote { get; set; }
        public long TQuote { get; set; }

    }
}


