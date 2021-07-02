using FluentValidation;

namespace BlazorFormsNetHosted.Shared
{
    public class SampleDtoValidator : AbstractValidator<SampleDto>
    {
        public SampleDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Age).InclusiveBetween(18, 80);
        }
    }
}
