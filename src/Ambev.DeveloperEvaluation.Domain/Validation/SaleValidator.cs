using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{

    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator()
        {
            RuleFor(sale => sale.DateSale)
                .NotEmpty();

            RuleFor(sale => sale.Customer)
                .NotEmpty()
                .MinimumLength(3).WithMessage("Customer must be at least 3 characters long.")
                .MaximumLength(200).WithMessage("Customer cannot be longer than 200 characters.");

            RuleFor(sale => sale.TotaSaleAmount)
                .NotEmpty();

            RuleFor(sale => sale.Branch)
                .MinimumLength(3).WithMessage("Customer must be at least 3 characters long.")
                .MaximumLength(200).WithMessage("Customer cannot be longer than 200 characters.");         

            RuleFor(sale => sale.Products)
                .NotNull()
                .WithMessage("products cannot be null.");
        }
    }
}
