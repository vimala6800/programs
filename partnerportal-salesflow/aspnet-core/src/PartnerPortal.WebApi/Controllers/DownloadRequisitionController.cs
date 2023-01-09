using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PartnerPortal.Application.Requisitions.Export_Requisition;

namespace PartnerPortal.WebApi.Controllers
{
    
    public class DownloadRequisitionController : ApiControllerBase
    {
        [HttpGet("{id}")]
        public async Task<FileResult> Get(Guid id)
        {
            var vm = await Mediator.Send(new ExportRequisitionQuery { RequisitionID = id });

            return File(vm.Content, vm.ContentType, vm.FileName);
        }

    }
}
