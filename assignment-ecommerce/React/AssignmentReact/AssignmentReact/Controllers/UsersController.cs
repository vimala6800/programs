using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssignmentReact.Models;
using NuGet.Protocol.Plugins;

namespace AssignmentReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ReactAssignmentContext _context;

        public UsersController(ReactAssignmentContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("PostUser")]
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var UL = new User();
            try
            {
                if (UL.Id == 0)
                {
                    UL.Name = user.Name;
                    UL.Email = user.Email;
                    UL.Password = user.Password;
                    UL.Role = "customer";
                    _context.Users.Add(UL);
                    await _context.SaveChangesAsync();

                    //return RedirectToAction("Response", new {Message="Registered"});

                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok();
            //return RedirectToAction("Response",new {Message="Failed"});
            /*_context.Users.Add(user);
            await _context.SaveChangesAsync();



           return CreatedAtAction("GetUser", new { id = user.Id }, user);*/
        }
        [Route("Login")]
        [HttpPost]
        public async Task<ActionResult<User>> Login(login login1)
        {
            var log = _context.Users.Where(x => x.Email.Equals(login1.Email) && x.Password.Equals(login1.Password)).FirstOrDefault();
            if (log == null)
            {
                return Ok();
                //return RedirectToAction("Response", new { Message = "Invaliduser" });



            }
            else
            {
                return Ok();
                //return RedirectToAction("Response", new { Message = "loged in" });



            }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
