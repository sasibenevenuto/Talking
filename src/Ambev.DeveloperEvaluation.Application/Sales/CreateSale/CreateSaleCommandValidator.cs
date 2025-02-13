using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleCommand that defines validation rules for sale creation command.
    /// </summary>
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - DateSale: Date equal to or greater than today
        /// - Customer: Not empty
        /// - TotaSaleAmount: Must be greater than 0
        /// - Products: Quantity greater than 0
        /// </remarks>
        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.DateSale).Must(s => s >= DateTime.Now);
            RuleFor(sale => sale.Customer).NotEmpty();
            RuleFor(sale => sale.TotaSaleAmount).Must(p => p > 0);
            RuleFor(sale => sale.Products).Must(p => p.Count > 0);
        }
    }
}
