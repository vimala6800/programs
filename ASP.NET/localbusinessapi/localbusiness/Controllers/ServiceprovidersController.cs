using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using localbusiness.Models;

namespace localbusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceprovidersController : ControllerBase
    {
        private readonly localbusinessContext _context;

        public ServiceprovidersController(localbusinessContext context)
        {
            _context = context;
        }

        // GET: api/Serviceproviders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Serviceprovider>>> GetServiceproviders()
        {
            return await _context.Serviceproviders.ToListAsync();
        }

        // GET: api/Serviceproviders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Serviceprovider>> GetServiceprovider(int id)
        {
            var serviceprovider = await _context.Serviceproviders.FindAsync(id);

            if (serviceprovider == null)
            {
                return NotFound();
            }

            return serviceprovider;
        }

        // PUT: api/Serviceproviders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceprovider(int id, Serviceprovider serviceprovider)
        {
            if (id != serviceprovider.Id)
            {
                return BadRequest();
            }

            _context.Entry(serviceprovider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceproviderExists(id))
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

        // POST: api/Serviceproviders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Serviceprovider>> PostServiceprovider(Serviceprovider serviceprovider)
        {
            _context.Serviceproviders.Add(serviceprovider);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceprovider", new { id = serviceprovider.Id }, serviceprovider);
        }

        // DELETE: api/Serviceproviders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceprovider(int id)
        {
            var serviceprovider = await _context.Serviceproviders.FindAsync(id);
            if (serviceprovider == null)
            {
                return NotFound();
            }

            _context.Serviceproviders.Remove(serviceprovider);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServiceproviderExists(int id)
        {
            return _context.Serviceproviders.Any(e => e.Id == id);
        }
    }
}
