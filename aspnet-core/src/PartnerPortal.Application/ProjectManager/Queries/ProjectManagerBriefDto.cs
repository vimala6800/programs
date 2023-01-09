using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Application.Common.Mappings;
using PartnerPortal.Application.Common.Models;
using PartnerPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Application.ProjectManagers.Queries
{
    public class ProjectManagerBriefDto : IMapFrom<ProjectManager>
    {
        public Guid ProjectManagerID { get; set; }
        public string ProjectManagerName { get; set; }
        public string EmployeeID { get; set; }
        public DateTime JoiningDate { get; set; }
        public string PMEmailID { get; set; }
        public string PMPhoneNumber { get; set; }
        public int PMStatus { get; set; }


        public Guid SkillID { get; set; }
        public string SkillName { get; set; }
    }
    
}
