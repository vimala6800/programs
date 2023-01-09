using MediatR;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartnerPortal.Application.AdminBenchResources.Commands
{
    public record CreateBenchCommand : IRequest<int>
    {

        public Guid BenchId { get; set; }
        public Guid PartnerID { get; set; }
        public int NoOfResource { get; set; }
        public string yearsOfExperience { get; set; }
        public string SkillSet { get; set; }
        public double RatePerHrUSD { get; set; }

    }

    public class CreateBenchCommandHandler : IRequestHandler<CreateBenchCommand, int>
    {
        private readonly IApplicationDbContext dbContext;

        public CreateBenchCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        public async Task<int> Handle(CreateBenchCommand request, CancellationToken cancellationToken)
        {

            var entity = new Bench
            {
                BenchID = new Guid(),
                PartnerID = request.PartnerID,
                NoOfResource = request.NoOfResource,
                yearsOfExperience = request.yearsOfExperience,
                SkillSet = request.SkillSet,
                RatePerHrUSD = request.RatePerHrUSD

            };
            dbContext.BenchResources.Add(entity);

            await dbContext.SaveChangesAsync(cancellationToken);

            return 1;
        }
    }


}

