using FluentValidation;
using ShopsRUs.Dtos;

namespace ShopsRUs.Configuration
{
    public class InvoiceValidation : AbstractValidator<InvoiceDTO>
    {
        public InvoiceValidation()
        {
            RuleFor(c => c.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Lütfen Fatura Numarasını boş geçmeyiniz.");
            RuleFor(c => c.UserType).InclusiveBetween(1, 3).WithMessage("Lütfen Müşteri 1 ile 3 arası giriniz");
            RuleFor(c => c.UserSinceto).NotEmpty().LessThanOrEqualTo(v => DateTime.Today);
            RuleFor(c => c.InvoicePrice).InclusiveBetween(1, double.MaxValue).WithMessage("Lütfen Fatura Tutarını 0 dan büyük giriniz!!");
        }
    }
}
