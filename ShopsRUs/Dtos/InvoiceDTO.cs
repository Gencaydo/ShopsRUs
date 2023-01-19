using ShopsRUs.Models;

namespace ShopsRUs.Dtos
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public int UserType { get; set; }
        public DateTime UserSinceto { get; set; }
        public double InvoicePrice { get; set; }
    }
}
