using PartnerPortal.Application.Requisitions.Commands;
using PartnerPortal.Domain.Entities;

namespace PartnerPortal.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        //byte[] BuildSkillsFile(List<SkillsRecord> records);
        byte[] BuildRequisitionsFile(IEnumerable<RequisitionRecord> records);
    }
}
