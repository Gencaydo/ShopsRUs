using ShopsRUs.Controllers;
using ShopsRUs.Dtos;
using ShopsRUs.Services;

namespace ShopsRUs.Test
{
    public class UnitTest1
    {
        private readonly InvoiceController _controller;
        private readonly IInvoiceService _service;
        public UnitTest1()
        {
            _controller = new InvoiceController(_service);
        }
        [Fact]
        public void Test1()
        {
            InvoiceDTO testItem = new InvoiceDTO()
            {
                Id = 1,
                UserType = 1,
                UserSinceto = DateTime.Now,
                InvoicePrice = 1500
            };
            var result = _controller.CalculateInvoices(testItem);
        }
    }
}