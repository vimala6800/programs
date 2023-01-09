using MediatR;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Application.RateCards.Commands
{
    public record CreateRatesCommand : IRequest<int>
    {
        public Guid RateCardId { get; set; }
        public Guid SkillID { get; set; }
        public byte MinYrExperience { get; set; }



        public byte MaxYrExperience { get; set; }
        public double RatePerHrUSD { get; set; }

    }
    public class CreateRatesCommandHandler : IRequestHandler<CreateRatesCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public CreateRatesCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateRatesCommand request, CancellationToken cancellationToken)
        {
            var entity = new RateCard
            {
                RateCardId = request.RateCardId,

                SkillID = request.SkillID,
                MinYrExperience = request.MinYrExperience,
                MaxYrExperience = request.MaxYrExperience,
                RatePerHrUSD = request.RatePerHrUSD,

            };



            //entity.AddDomainEvent(new SalesPersonCreatedEvent(entity));



            _context.RateCards.Add(entity);



            await _context.SaveChangesAsync(cancellationToken);



            //return request.DepartmentID;
            return 1;



        }
    }
}

