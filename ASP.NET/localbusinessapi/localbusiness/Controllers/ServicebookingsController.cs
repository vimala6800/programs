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
    public class ServicebookingsController : ControllerBase
    {
        private readonly localbusinessContext _context;

        public ServicebookingsController(localbusinessContext context)
        {
            _context = context;
        }

        // GET: api/Servicebookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicebooking>>> GetServicebookings()
        {
            return await _context.Servicebookings.ToListAsync();
        }

        // GET: api/Servicebookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Servicebooking>> GetServicebooking(int id)
        {
            var servicebooking = await _context.Servicebookings.FindAsync(id);

            if (servicebooking == null)
            {
                return NotFound();
            }

            return servicebooking;
        }

        // PUT: api/Servicebookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServicebooking(int id, Servicebooking servicebooking)
        {
            if (id != servicebooking.Id)
            {
                return BadRequest();
            }

            _context.Entry(servicebooking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicebookingExists(id))
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

        // POST: api/Servicebookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Servicebooking>> PostServicebooking(Servicebooking servicebooking)
        {
            _context.Servicebookings.Add(servicebooking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServicebooking", new { id = servicebooking.Id }, servicebooking);
        }

        // DELETE: api/Servicebookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServicebooking(int id)
        {
            var servicebooking = await _context.Servicebookings.FindAsync(id);
            if (servicebooking == null)
            {
                return NotFound();
            }

            _context.Servicebookings.Remove(servicebooking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServicebookingExists(int id)
        {
            return _context.Servicebookings.Any(e => e.Id == id);
        }
    }
}
