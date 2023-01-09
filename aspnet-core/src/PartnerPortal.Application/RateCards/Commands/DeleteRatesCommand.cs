using MediatR;
using PartnerPortal.Application.Common.Exceptions;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerPortal.Application.RateCards.Commands
{
    public record DeleteRatesCommand(Guid Id) : IRequest;



    public class DeleteRatesCommandHandler : IRequestHandler<DeleteRatesCommand>
    {
        private readonly IApplicationDbContext _context;



        public DeleteRatesCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<Unit> Handle(DeleteRatesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.RateCards
                .FindAsync(new object[] { request.Id }, cancellationToken);



            if (entity == null)
            {
                throw new NotFoundException(nameof(RateCard), request.Id);
            }



            _context.RateCards.Remove(entity);



            await _context.SaveChangesAsync(cancellationToken);



            return Unit.Value;



        }
    }



}
