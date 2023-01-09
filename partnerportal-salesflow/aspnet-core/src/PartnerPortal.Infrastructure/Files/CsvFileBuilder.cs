using CsvHelper;
using PartnerPortal.Application.Common.Interfaces;
using PartnerPortal.Application.Requisitions.Commands;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Files.Maps;
using System.Globalization;

namespace PartnerPortal.Infrastructure.Files
{
    public class CsvFileBuilder : ICsvFileBuilder
    {

        public byte[] BuildRequisitionsFile(IEnumerable<RequisitionRecord> records)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

                csvWriter.Configuration.RegisterClassMap<RequisitionRecordMap>();
                csvWriter.WriteRecords(records);
            }

            return memoryStream.ToArray();
        }
    }
}
