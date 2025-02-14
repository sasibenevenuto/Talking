using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{

    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - SaleId: Cannot be set to None
        /// - Amount: Must be greater than 0
        /// - UnitPrice: Must be greater than 0
        /// - Discount: Must be greater than or equal to 0
        /// </remarks>
        public CreateProductRequestValidator()
        {
            RuleFor(product => product.SaleId).NotEmpty();
            RuleFor(product => product.Amount).Must(p => p > 0);
            RuleFor(product => product.UnitPrice).Must(p => p > 0);
            RuleFor(product => product.Discount).Must(p => p >= 0);
        }
    }
}
