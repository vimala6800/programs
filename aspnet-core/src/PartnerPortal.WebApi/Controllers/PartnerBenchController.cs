using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Infrastructure.Persistence;

namespace PartnerPortal.WebApi.Controllers
{

    public class PartnerBenchController : ApiControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PartnerBenchController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
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
                var partner = await dbContext.BenchResources.Where(x => x.PartnerID == partnerID).ToListAsync();

                if (partner == null)
                {
                    return NotFound();
                }
                return Ok(partner);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
