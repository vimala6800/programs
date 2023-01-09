using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Identity;
using PartnerPortal.Infrastructure.Persistence;
using System.Text;
using YamlDotNet.Core;

namespace PartnerPortal.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileImageController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public ProfileImageController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> PutUserDisplayImage(Guid id, IFormFile image)
        {
            var u = await _userManager.FindByIdAsync(id.ToString());
            var roleIdUserIDCombo = await _dbContext.UserRoles.Where(x => x.UserId == id.ToString()).FirstOrDefaultAsync();
            var roleId = roleIdUserIDCombo.RoleId;
            var role = await _roleManager.FindByIdAsync(roleId);

            var path = "";
            if (role.Name == "ProjectManager")
            {
                var pm = await _dbContext.ProjectManagers.Where(p => p.PMUserID == id).FirstOrDefaultAsync();
                path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "wwwroot", "Resources", "ProfileImages", "ProjectManager", pm.PMUserID.ToString()));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using (var fileStream = new FileStream(Path.Combine(path, image.FileName), FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }
                var url = Path.Combine("https://localhost:7184//Resources/ProfileImages/ProjectManager/" + pm.PMUserID.ToString() + "/", image.FileName);
                pm.PMPhoto = Encoding.ASCII.GetBytes(url);
                _dbContext.Entry(pm).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return StatusCode(StatusCodes.Status200OK,
                    new UserProfile
                    {
                        UserName = u.UserName,
                        Email = u.Email,
                        CompanyName = "Flatworld Solutions",
                        Address = "Bengaluru",
                        ContactNumber = pm.PMPhoneNumber,
                        Password = u.PasswordHash,
                        ImageUrl = url
                    });
            }
            else if(role.Name=="Partner")
            {
                var partner = await _dbContext.Partners.Where(p => p.SPOCUserID == id).FirstOrDefaultAsync();
                path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "wwwroot", "Resources", "ProfileImages", "Partner",partner.PartnerID.ToString()));
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using (var fileStream = new FileStream(Path.Combine(path, image.FileName), FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }
                var url= Path.Combine("https://localhost:7184//Resources/ProfileImages/Partner/"+ partner.PartnerID.ToString()+"/", image.FileName);
                partner.PartnerImage = Encoding.ASCII.GetBytes(url);
                _dbContext.Entry(partner).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return StatusCode(StatusCodes.Status200OK,
                    new UserProfile
                    {
                        UserName = u.UserName,
                        Email = u.Email,
                        CompanyName = partner.PartnerName,
                        Address = partner.Address1,
                        ContactNumber = u.PhoneNumber,
                        Password = u.PasswordHash,
                        ImageUrl = url
                    });
            }
            //roles associated with OtherRoles Table
            else
            {
                if (role.Name == "Administrator")
                {
                    var extraData = await _dbContext.OtherRoles.Where(p => p.UserId == id).FirstOrDefaultAsync();
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "wwwroot", "Resources", "ProfileImages", "Admin"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, image.FileName), FileMode.Create))
                    {
                        await image.CopyToAsync(fileStream);
                    }
                    extraData.Photo = Path.Combine("https://localhost:7184//Resources/ProfileImages/Admin/", image.FileName);
                    _dbContext.Entry(extraData).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    return StatusCode(StatusCodes.Status200OK,
                        new UserProfile
                        {
                            UserName = u.UserName,
                            Email = u.Email,
                            CompanyName = extraData.Company,
                            Address = extraData.Address,
                            ContactNumber = u.PhoneNumber,
                            Password = u.PasswordHash,
                            ImageUrl = extraData.Photo
                        });
                }
                //for sales and other newly added roles
                else
                {
                    var extraData = await _dbContext.OtherRoles.Where(p => p.UserId == id).FirstOrDefaultAsync();
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "wwwroot", "Resources", "ProfileImages", role.Name,id.ToString()));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, image.FileName), FileMode.Create))
                    {
                        await image.CopyToAsync(fileStream);
                    }
                    extraData.Photo = Path.Combine("https://localhost:7184//Resources/ProfileImages/"+role.Name+"/"+id+"/", image.FileName);
                    _dbContext.Entry(extraData).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    return StatusCode(StatusCodes.Status200OK,
                        new UserProfile
                        {
                            UserName = u.UserName,
                            Email = u.Email,
                            CompanyName = extraData.Company,
                            Address = extraData.Address,
                            ContactNumber = u.PhoneNumber,
                            Password = u.PasswordHash,
                            ImageUrl = extraData.Photo
                        });
                }
            }
        }
    }
}
