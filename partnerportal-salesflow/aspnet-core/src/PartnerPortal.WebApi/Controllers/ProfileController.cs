using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Identity;
using PartnerPortal.Infrastructure.Persistence;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace PartnerPortal.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        //Admin
        public ProfileController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProfileByUserID(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var roleIdUserIDCombo = await _dbContext.UserRoles.Where(x => x.UserId == id).FirstOrDefaultAsync();
            var roleId = roleIdUserIDCombo.RoleId;
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role.Name == "Partner")
            {
                var partner = await _dbContext.Partners.Where(p => p.SPOCUserID.ToString() == id).FirstOrDefaultAsync();
                return StatusCode(StatusCodes.Status200OK,
                new UserProfile
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    CompanyName = partner.PartnerName,
                    Address = partner.Address1,
                    //conflict type error between byte[] and string,using ToString() to  remove squiggle
                    ImageUrl = Encoding.ASCII.GetString(partner.PartnerImage),
                    ContactNumber = user.PhoneNumber,
                    Password = user.PasswordHash
                });
            }
            else if (role.Name == "ProjectManager")
            {
                var pm = await _dbContext.ProjectManagers.Where(p => p.PMUserID.ToString() == id).FirstOrDefaultAsync();
                return StatusCode(StatusCodes.Status200OK,
                new UserProfile
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    CompanyName = "Flatworld Solutions",
                    Address = "Bengaluru",
                    ImageUrl = Encoding.ASCII.GetString(pm.PMPhoto),
                    ContactNumber = user.PhoneNumber,
                    Password = user.PasswordHash
                });
            }
            else
            {
                var extraData = await _dbContext.OtherRoles.Where(p => p.UserId.ToString() == id).FirstOrDefaultAsync();
                return StatusCode(StatusCodes.Status200OK,
                    new UserProfile
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                        CompanyName = extraData.Company,
                        Address = extraData.Address,
                        ContactNumber = user.PhoneNumber,
                        ImageUrl = extraData.Photo,
                        Password = user.PasswordHash
                    });
            }

        }

        [HttpPut("{id}")]

        public async Task<ActionResult> EditUserProfileTextFields(Guid id, UserProfile user)
        {
            var u = await _userManager.FindByIdAsync(id.ToString());
            var roleIdUserIDCombo = await _dbContext.UserRoles.Where(x => x.UserId == id.ToString()).FirstOrDefaultAsync();
            var roleId = roleIdUserIDCombo.RoleId;
            var role = await _roleManager.FindByIdAsync(roleId);

            u.UserName = user.UserName;
            u.Email = user.Email;
            u.PasswordHash = user.Password;
            u.PhoneNumber = user.ContactNumber;
            _dbContext.Entry(u).State = EntityState.Modified;

            if (role.Name == "Partner")
            {
                var partner = await _dbContext.Partners.Where(p => p.SPOCUserID == id).FirstOrDefaultAsync();
                partner.PartnerName = user.CompanyName;
                partner.Address1 = user.Address;
                _dbContext.Entry(partner).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK,
                new UserProfile
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    CompanyName = "Fws",
                    Address = "Indiranagar",
                    ContactNumber = "7362889401",
                    Password = user.Password,
                });

            }
            else if (role.Name == "ProjectManager")
            {
                //yet to add
                return NoContent();
            }
            //for administrator ,sales and all newly created roles
            else
            {
                var extraData = await _dbContext.OtherRoles.Where(p => p.UserId == id).FirstOrDefaultAsync();
                extraData.Company = user.CompanyName;
                extraData.Address = user.Address;
                _dbContext.Entry(extraData).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK,
                new UserProfile
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    CompanyName = extraData.Company,
                    Address = extraData.Address,
                    ContactNumber = user.ContactNumber,
                    Password = user.Password,
                });
            }
        }
    }
}
