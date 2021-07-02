using FluentValidation;

namespace BlazorForms.Pages.Example8
{
    public class ModelValidator : AbstractValidator<Model>
    {
        public ModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Age).InclusiveBetween(18, 80);
            RuleFor(x => x.Password).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Nested).SetValidator(new NestedModelValidator());
        }
    }

    public class NestedModelValidator : AbstractValidator<NestedModel>
    {
        public NestedModelValidator()
        {
            RuleFor(x => x.Address).NotEmpty().MaximumLength(50);
        }
    }
}
