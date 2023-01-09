using MediatR;
using PartnerPortal.Application.Common.Exceptions;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Application.Skills.Commands
{
    public record UpdateSkillsDetailCommand : IRequest
    {
        public Guid SkillID { get; set; }
        public string SkillName { get; set; }

    }



    public class UpdateSkillsDetailCommandHandler : IRequestHandler<UpdateSkillsDetailCommand>
    {
        private readonly IApplicationDbContext _context;



        public UpdateSkillsDetailCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<Unit> Handle(UpdateSkillsDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Skills
                .FindAsync(new object[] { request.SkillID }, cancellationToken);



            if (entity == null)
            {
                throw new NotFoundException(nameof(Skill), request.SkillID);
            }



            entity.SkillName = request.SkillName;



            await _context.SaveChangesAsync(cancellationToken);



            return Unit.Value;
        }
    }


}
