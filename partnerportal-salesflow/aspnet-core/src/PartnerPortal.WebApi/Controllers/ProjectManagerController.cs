using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Application.ProjectManagers.Commands;
using PartnerPortal.Application.ProjectManagers.Queries;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Identity;
using PartnerPortal.Infrastructure.Persistence;
using System.Runtime.InteropServices;
using PartnerPortal.Application.Common.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection.Metadata.Ecma335;
using SendGrid.Helpers.Mail;
using PartnerPortal.Application.Partners.Queries;

namespace PartnerPortal.WebApi.Controllers
{
    
    public class ProjectManagerController : ApiControllerBase
    {
        private readonly ApplicationDbContext _fullStackDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        

        public ProjectManagerController(ApplicationDbContext fullStackDbContext, UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            _fullStackDbContext = fullStackDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpGet]
        public async Task<ActionResult> GetAllEmployees()
        {
            
            var projectmanagers1 = await _fullStackDbContext.ProjectManagers.ToListAsync();
            var projectSkill1 = await _fullStackDbContext.projectManagerSkills.ToListAsync();
            var skill1 = await _fullStackDbContext.Skills.ToListAsync();




            var Projectmanager = from p in projectmanagers1
                                 join ps in projectSkill1 on p.ProjectManagerID equals ps.ProjectManagerID
                                 join s in skill1 on ps.SkillID equals s.SkillID
                                 
                                 select new ProjectManagerBriefDto()
                                 {

                                     ProjectManagerID = p.ProjectManagerID,
                                     EmployeeID = p.EmployeeID,
                                     
                                     ProjectManagerName = p.ProjectManagerName,
                                    
                                     JoiningDate = p.JoiningDate,
                                     PMEmailID = p.PMEmailID,
                                     PMPhoneNumber = p.PMPhoneNumber,
                                     PMStatus = p.PMStatus,
                                     
                                     SkillID = s.SkillID,
                                     SkillName = s.SkillName



                                 };





            return Ok(Projectmanager);
        }
        
        [HttpPost]
       
        public async Task<IActionResult> Register([FromBody] Users registerUser, string role)
        {
            //Check User Exist
            var userExist = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExist != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                new Response { Status = "Error", Message = "User already exists!" });
            }

            //Add the User in the database
            ApplicationUser user = new()
            {
                Id=Guid.NewGuid().ToString(),
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username,
                PhoneNumber = registerUser.PhoneNumber,
                TwoFactorEnabled = true
            };
            if (await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user);
                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { Status = "Error", Message = "User Failed to Create" });
                }
                //Add role to the user....

                await _userManager.AddToRoleAsync(user, role);

                ////Add Token to Verify the email....



                return StatusCode(StatusCodes.Status200OK,
                 new Domain.Entities.Response { Status = "Success", Message = $"User created {user.Id}  SuccessFully" });

            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                new Response { Status = "Error", Message = "This Role Doesnot Exist." });
            }


        }
        


        [HttpPost("AddPM")]
        public async Task<ActionResult<int>> Create(CreateProjectManagerCommand command)
        {

            return await Mediator.Send(command);
        }






        [HttpGet]
        [Route("{projectManagerID:Guid}")]
        public async Task<IActionResult> GetEmployee([FromRoute] Guid projectManagerID)
        {

            var projectmanagers = await _fullStackDbContext.ProjectManagers.ToListAsync();
            var projectSkill = await _fullStackDbContext.projectManagerSkills.ToListAsync();
            var skill = await _fullStackDbContext.Skills.ToListAsync();




            var Projectmanager = from p in projectmanagers
                                 join ps in projectSkill on p.ProjectManagerID equals ps.ProjectManagerID
                                 join s in skill on ps.SkillID equals s.SkillID
                                 where (p.ProjectManagerID == projectManagerID)
                                 select new ProjectManagerBriefDto()
                                 {

                                     ProjectManagerID = p.ProjectManagerID,
                                     EmployeeID = p.EmployeeID,
                                     
                                     ProjectManagerName = p.ProjectManagerName,
                                     
                                     JoiningDate = p.JoiningDate,
                                     PMEmailID=p.PMEmailID,
                                     PMPhoneNumber= p.PMPhoneNumber,
                                     PMStatus=p.PMStatus,
                                     
                                     SkillID=s.SkillID,
                                     SkillName = s.SkillName



                                 };





            return Ok(Projectmanager);



            

        }

        [HttpGet("skill")]

        public Skill[] Skills()
        {
            var projectmanagerskills = _fullStackDbContext.Skills.ToList();
            return projectmanagerskills.ToArray();
        }

        [HttpGet("pmskills")]
        
        public ProjectManagerSkill[] GetPMSkills()
        {
            var projectmanagerskills = _fullStackDbContext.projectManagerSkills.ToList();
            return projectmanagerskills.ToArray();
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateProjectManagerCommand command)
        {
            if (id != command.ProjectManagerID)
            {
                return BadRequest();
            }



            await Mediator.Send(command);



            return NoContent();
        }
        


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteProjectManagerCommand(id));



            return NoContent();
        }

        

    }
}
