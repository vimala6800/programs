using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Persistence;

namespace PartnerPortal.WebApi.Controllers
{
    public class PartnerController : ApiControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PartnerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllPartner()
        {
            var entity = await dbContext.Partners.ToListAsync();
            return Ok(entity);
        }


        [HttpGet("{partnerID}")]
        public async Task<IActionResult> GetPartner([FromRoute] Guid partnerID)
        {
            try
            {
                if (dbContext.BenchResources == null)
                {
                    return NotFound();
                }
                var partner = await dbContext.Partners.FirstOrDefaultAsync(x => x.PartnerID == partnerID);

                if (partner == null)
                {
                    return NotFound();
                }
                return Ok(partner);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult<Partner>> PostPartner(Partner partner)
        {
            try
            {
                dbContext.Partners.Add(partner);
                await dbContext.SaveChangesAsync();

                return NoContent();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
