using FluentValidation;
using kütüphaneler.Models;
using Microsoft.Identity.Client;

namespace kütüphaneler.Validator
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} Alanı Boş Olamaz.";
        public CustomerValidator()
        {
            
            RuleFor(x=>x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.City).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x=>x.Address).NotEmpty().WithMessage(NotEmptyMessage).Length(0,20).WithMessage("Adres 20 karakteri geçemez");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddYears(-18)>=x;
            }).WithMessage("Yaşınız 18 yaşından büyük olmalıdır.");

            //RuleForEach(x=>x.Addresss).SetValidator(new AddressValidator());
        }
    }
}
