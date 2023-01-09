using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Application.RateCards.Commands;
using PartnerPortal.Application.Skills.Commands;
using PartnerPortal.Application.TodoLists.Queries.GetTodos;
using PartnerPortal.Infrastructure.Persistence;

namespace PartnerPortal.WebApi.Controllers
{
    public class RateCardsController : ApiControllerBase
    {


        private readonly ApplicationDbContext dbContext;
        public RateCardsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetRateCardsInfo()
        {
            var rate = await dbContext.RateCards.ToListAsync();
            var sk = await dbContext.Skills.ToListAsync();
            var S = from r in rate
                    join a in sk on r.SkillID equals a.SkillID
                    select new RateCardsDto()
                    {
                        RateCardId = r.RateCardId,
                        SkillID = r.SkillID,
                       
                        Skill = a.SkillName,
                        MaxYrExperience = r.MaxYrExperience,
                        MinYrExperience = r.MinYrExperience,

                        RatePerHrUSD = r.RatePerHrUSD
                    };
            return Ok(S);
        }
        

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateRatesCommand command)
        {
            return await Mediator.Send(command);
        }
        [HttpDelete("{RateCardId}")]
        public async Task<ActionResult> Delete(Guid RateCardId)
        {
            await Mediator.Send(new DeleteRatesCommand(RateCardId));



            return NoContent();
        }
        [HttpGet("{ratecardId}")]
        public async Task<IActionResult> GetRateCard([FromRoute] Guid ratecardId)
        {
            if (dbContext.RateCards == null)
            {
                return NotFound();
            }
            var rate = await dbContext.RateCards.FirstOrDefaultAsync(x => x.RateCardId == ratecardId);



            if (rate == null)
            {
                return NotFound();
            }
            return Ok(rate);



        }
        [HttpGet("{skill}")]
        public async Task<IActionResult> GetRateCardsskill()
        {
            var rate = await dbContext.RateCards.ToListAsync();
            var sk = await dbContext.Skills.ToListAsync();
            var S = from a in sk
                    join r in rate on a.SkillID equals r.SkillID
                    select new RateCardsDto()
                    {
                        RateCardId = r.RateCardId,
                        SkillID = r.SkillID,

                        Skill = a.SkillName,
                        MaxYrExperience = r.MaxYrExperience,
                        MinYrExperience = r.MinYrExperience,

                        RatePerHrUSD = r.RatePerHrUSD
                    };
            return Ok(S);
        }
        [HttpGet]
        [Route("{skillID:Guid}")]
        public async Task<IActionResult> GetRateCardBySkillID([FromRoute] Guid skillID)
        {



            // var rate = await _context.RateCard.FirstOrDefaultAsync(x => x.SkillID == skillID);



            var rate = await dbContext.RateCards.ToListAsync();
            var sk = await dbContext.Skills.ToListAsync();



            var S = from r in rate
                    join a in sk on r.SkillID equals a.SkillID
                    where (r.SkillID == skillID)
                    select new RateCardsDto()
                    {
                        RateCardId = r.RateCardId,
                        SkillID = r.SkillID,
                        
                       
                        MaxYrExperience = r.MaxYrExperience,
                        MinYrExperience = r.MinYrExperience,



                        RatePerHrUSD = r.RatePerHrUSD



                    };



            return Ok(S);

        }


        }
}
