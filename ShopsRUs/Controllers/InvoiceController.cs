using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Dtos;
using ShopsRUs.Services;

namespace ShopsRUs.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _ınvoiceService;

        public InvoiceController(IInvoiceService ınvoiceService)
        {
            _ınvoiceService = ınvoiceService;
        }

        [HttpPost]
        public async Task<double> CalculateInvoices(InvoiceDTO ınvoiceDTO)
        {
            var response = await _ınvoiceService.CalculateInvoiceAsync(ınvoiceDTO);
            return response;
        }

    }
}
