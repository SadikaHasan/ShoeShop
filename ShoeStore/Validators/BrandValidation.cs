using FluentValidation;
using ShoeStore.Models.models;
using ShoeStore.Models.Requests;

namespace ShoeStore.Validators
{
    public class BrandValidation:
         AbstractValidator<Brand>
    public class SomeRequestValidator
    {
        RuleFor(x=>x.Id)
            .NotNull()
            .NotEmpty();

        RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(10);

        RuleFor(x=>x.BirthDay)
            .NotNull()
            .NotEmpty()

    }
    
}
