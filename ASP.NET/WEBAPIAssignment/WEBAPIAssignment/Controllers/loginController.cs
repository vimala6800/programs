using AspNetCoreWebApi6.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WEBAPIAssignment.Models;

namespace WEBAPIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly userContext _dbContext;

        public loginController(userContext dbContext)
        {
            _dbContext = dbContext;
        }

      //  PUT:api/user
       [HttpGet("{search}")]
        public async Task<ActionResult>Loginusers(String email,string password,user user)
        {

            if(email != user.email && password!=user.password)
                {
                   return NotFound();
                }
            var display = await _dbContext.Users.FindAsync(email,password);
            if(display == null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(Loginusers), new { Id = user.Id },user);


        }
    }
}
       /* public async Task<ActionResult<IEnumerable<login>>> Search(string email, string password)
        {
            try
            {
                var result = await loginContext.Search(email, password);
                return (_dbContext.Users?.Any(e => e.Id == Id)).GetValueOrDefault();
                if (result.Any())
                {
                    return Ok(result);
                }
            }
            catch (Exception)
            {
                return StatusCode();
            } 

        }*/
        /*(Id != null)
           {
               return NotFound();
           }
           var sai = await _dbContext.Users.FindAsync(Id);
           if (sai != null)
           {
               return NotFound();

           }

               return CreatedAtAction(nameof(loginusers), new { Id = user.Id }, sai);

           //return CreatedAtAction(nameof(loginusers), new { id = user.Id }, sai);
           //dbContext.users. await _dbContext.SaveChangesAsync();
           //return user();
       }
           private bool userExists(long id)
           {
               return (_dbContext.Users?.Any(e => e.Id == id)).GetValueOrDefault();
           }

          *//* public IActionResult Index()
       {
           //return View();
       }*//*
    }
}

*/