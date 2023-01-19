using ShopsRUs.Dtos;
using ShopsRUs.Models;

namespace ShopsRUs.Services
{
    public class InvoiceService : IInvoiceService
    {
        public async Task<double> CalculateInvoiceAsync(InvoiceDTO invoiceDTO)
        {
            double totaldiscount = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            if (invoiceDTO.UserType == (int)UserType.Employee) totaldiscount = 0.3;
            if (invoiceDTO.UserType == (int)UserType.Affiliate) totaldiscount = 0.1;
            if (invoiceDTO.UserType == (int)UserType.Customer)
            {
                TimeSpan TotalDay = DateTime.Today - invoiceDTO.UserSinceto;
                if (TotalDay.Days > 730) totaldiscount = 0.05;
            }

            if (invoiceDTO.InvoicePrice > 100)
            {
                a = invoiceDTO.InvoicePrice % 100;
                b = invoiceDTO.InvoicePrice - a;
                c = b / 100;
            }
            else c = 1;

            double FinalInvoice = invoiceDTO.InvoicePrice * (1 - (totaldiscount + 0.05 * c));

            return FinalInvoice;
        }
    }
}
