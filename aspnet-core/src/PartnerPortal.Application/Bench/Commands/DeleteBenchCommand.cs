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

namespace PartnerPortal.Application.AdminBench.Commands
{
    public record DeleteBenchCommand(Guid benchID) : IRequest;

    public class DeleteBenchCommandHandler : IRequestHandler<DeleteBenchCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteBenchCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Unit> Handle(DeleteBenchCommand request, CancellationToken cancellationToken)
        {
            var entity = await dbContext.BenchResources
                .Where(l => l.BenchID == request.benchID).SingleOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Bench), request.benchID);
            }
            dbContext.BenchResources.Remove(entity);

            await dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
