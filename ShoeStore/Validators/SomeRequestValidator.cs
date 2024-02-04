using FluentValidation;
using System.Data;

namespace ShoeStore.Validators
{
    public class SomeRequestValidator :
        AbstractValidator<SomeRequest>
    public class SomeRequestValidator
    {
        RuleFor(x=>x.SomeIntValue)
            .NotNull()
            .NotEmpty()
            .GreaterThan(36)
            .LessThan(40);

        RuleFor(x=>x.Name)
            .NotNull()
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(10);
    }
}
