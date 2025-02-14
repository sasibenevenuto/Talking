using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Validator for CreateSaleCommand that defines validation rules for sale creation command.
    /// </summary>
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - DateSale: Date equal to or greater than today
        /// - Customer: Not empty
        /// - TotaSaleAmount: Must be greater than 0
        /// - Products: Quantity greater than 0
        /// </remarks>
        public CreateSaleRequestValidator()
        {
            RuleFor(sale => sale.DateSale).Must(s => s >= DateTime.Now.Date);
            RuleFor(sale => sale.Customer).NotEmpty();
            RuleFor(sale => sale.TotaSaleAmount).Must(p => p > 0);
            RuleFor(sale => sale.Products).Must(p => p.Count > 0);
        }
    }
}
