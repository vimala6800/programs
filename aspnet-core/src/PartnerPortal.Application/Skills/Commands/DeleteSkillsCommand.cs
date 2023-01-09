using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public record DeleteSkillsCommand(Guid skillID) : IRequest;

    public class DeleteSkillsCommandHandler : IRequestHandler<DeleteSkillsCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteSkillsCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Unit> Handle(DeleteSkillsCommand request, CancellationToken cancellationToken)
        {
            var entity = await dbContext.Skills
            .Where(l => l.SkillID == request.skillID).SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Skills), request.skillID);
            }
            dbContext.Skills.Remove(entity);

            await dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }


}
