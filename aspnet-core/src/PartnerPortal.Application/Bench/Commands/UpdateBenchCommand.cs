using MediatR;
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
    public record UpdateBenchCommand : IRequest
    {
        public Guid BenchID { get; set; }
        public Guid PartnerID { get; set; }
        public int NoOfResource { get; set; }
        public string yearsOfExperience { get; set; }
        public string SkillSet { get; set; }
        public double RatePerHrUSD { get; set; }

    }
    public class UpdateBenchCommandHandler : IRequestHandler<UpdateBenchCommand>

    {
        private readonly IApplicationDbContext dbContext;

        public UpdateBenchCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public async Task<Unit> Handle(UpdateBenchCommand request, CancellationToken cancellationToken)
        {
            var entity = await dbContext.BenchResources
                 .FindAsync(new object[] { request.BenchID }, cancellationToken);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Bench), request.BenchID);
            }
            entity.PartnerID = request.PartnerID;
            entity.NoOfResource = request.NoOfResource;
            entity.SkillSet = request.SkillSet;
            entity.yearsOfExperience = request.yearsOfExperience;
            entity.RatePerHrUSD = request.RatePerHrUSD;


            await dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;



        }
    }
}