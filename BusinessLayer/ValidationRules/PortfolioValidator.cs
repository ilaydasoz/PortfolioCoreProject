using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Project name can not be empty!");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Project name must be 5 characters at least!");

        }
    }
}
