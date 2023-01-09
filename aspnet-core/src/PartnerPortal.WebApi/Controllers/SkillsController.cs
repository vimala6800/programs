 using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Application.Skills.Commands;
using PartnerPortal.Application.TodoLists.Queries.GetTodos;
using PartnerPortal.Infrastructure.Persistence;

namespace PartnerPortal.WebApi.Controllers
{
    public class SkillsController : ApiControllerBase
    {


        private readonly ApplicationDbContext dbContext;
        public SkillsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSkill()
        {
            var skill = await dbContext.Skills.ToListAsync();
            return Ok(skill);
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateSkillsCommand command)
        {
            return await Mediator.Send(command);
        }
        [HttpDelete("{SkillID}")]
        public async Task<ActionResult> Delete(Guid SkillID)
        {
            await Mediator.Send(new DeleteSkillsCommand(SkillID));



            return NoContent();
        }
        [HttpGet("{skillID}")]
        public async Task<IActionResult> GetSkill([FromRoute] Guid skillID)
        {
            if (dbContext.Skills == null)
            {
                return NotFound();
            }
            var skill = await dbContext.Skills.FirstOrDefaultAsync(x => x.SkillID == skillID);



            if (skill == null)
            {
                return NotFound();
            }
            return Ok(skill);



        }
        [HttpPut("{skillID}")]
        public async Task<ActionResult<int>> Update(Guid skillID, UpdateSkillsDetailCommand Command)
        {
            if (skillID != Command.SkillID)
            {
                return BadRequest();
            }
            await Mediator.Send(Command);



            return NoContent();
        }
    }
}
