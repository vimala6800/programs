using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Application.AdminBench.Commands;
using PartnerPortal.Application.AdminBenchResources.Commands;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Persistence;

namespace PartnerPortal.WebApi.Controllers
{
    public class BenchController : ApiControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public BenchController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBench()
        {
            try
            {
            var bench = await dbContext.BenchResources.ToListAsync();
            return Ok(bench);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateBenchCommand command)
        {
            try
            {
                return await Mediator.Send(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{benchID}")]
        public async Task<IActionResult> GetBench([FromRoute] Guid benchID)
        {
            try
            {
                if (dbContext.BenchResources == null)
                {
                    return NotFound();
                }
                var bench = await dbContext.BenchResources.FirstOrDefaultAsync(x => x.BenchID == benchID);

                if (bench == null)
                {
                    return NotFound();
                }
                return Ok(bench);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{benchID}")]
        public async Task<ActionResult<int>> Update(Guid benchID, UpdateBenchCommand Command)
        {
            try
            {
                if (benchID != Command.BenchID)
                {
                    return BadRequest();
                }
                await Mediator.Send(Command);

                return NoContent();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{benchID}")]
        public async Task<ActionResult> Delete(Guid benchID)
        {
            try
            {
                await Mediator.Send(new DeleteBenchCommand(benchID));

                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
