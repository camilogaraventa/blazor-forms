using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Pages.Example4
{
    public class ModelValidator : AbstractValidator<Model>
    {
        public ModelValidator(IValidator<NestedModel> nestedModelValidator)
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Age).InclusiveBetween(18, 80);
            RuleFor(x => x.Nested).SetValidator(nestedModelValidator);
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
