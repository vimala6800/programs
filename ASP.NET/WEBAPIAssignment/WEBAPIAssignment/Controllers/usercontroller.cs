using AspNetCoreWebApi6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPIAssignment.Models;

namespace WEBAPIAssignment.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class usersController : ControllerBase
        {
            private readonly userContext _dbContext;

            public usersController(userContext dbContext)
            {
                _dbContext = dbContext;
            }

            // GET: api/users
            [HttpGet]
            public async Task<ActionResult<IEnumerable<user>>> Getuser()
            {
                if (_dbContext.Users == null)
                {
                    return NotFound();
                }
                return await _dbContext.Users.ToListAsync();
            }

            // GET: api/users/5
            [HttpGet("{id}")]
            public async Task<ActionResult<user>> Getuser(int id)
            {
                if (_dbContext.Users == null)
                {
                    return NotFound();
                }
                var user = await _dbContext.Users.FindAsync(id);

                if (user == null)
                {
                    return NotFound();
                }

                return user;
            }

            // POST: api/users
            [HttpPost]
            public async Task<ActionResult<user>> Postuser(user user)
            {
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();

                return CreatedAtAction(nameof(Getuser), new { id = user.Id }, user);
            }

            // PUT: api/users/5
            [HttpPut("{id}")]
            public async Task<IActionResult> Putuser(int id, user user)
            {
                if (id != user.Id)
                {
                    return BadRequest();
                }

                _dbContext.Entry(user).State = EntityState.Modified;

                try
                {
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!userExists(id))
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

            // DELETE: api/users/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> Deleteuser(int id)
            {
                if (_dbContext.Users == null)
                {
                    return NotFound();
                }

                var movie = await _dbContext.Users.FindAsync(id);
                if (movie == null)
                {
                    return NotFound();
                }

                _dbContext.Users.Remove(movie);
                await _dbContext.SaveChangesAsync();

                return NoContent();
            }
            private bool userExists(long id)
            {
                return (_dbContext.Users?.Any(e => e.Id == id)).GetValueOrDefault();
            }

        }
    }
