using ShopsRUs.Dtos;

namespace ShopsRUs.Services
{
    public interface IInvoiceService
    {
        Task<double> CalculateInvoiceAsync(InvoiceDTO ınvoiceDTO);
    }
}
