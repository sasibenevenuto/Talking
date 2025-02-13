using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    /// <summary>
    /// Validator for CreateProductCommand that defines validation rules for product creation command.
    /// </summary>
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - SaleId: Cannot be set to None
        /// - Amount: Must be greater than 0
        /// - UnitPrice: Must be greater than 0
        /// - Discount: Must be greater than or equal to 0
        /// </remarks>
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.SaleId).NotEmpty();
            RuleFor(product => product.Amount).Must(p => p > 0);
            RuleFor(product => product.UnitPrice).Must(p => p > 0);
            RuleFor(product => product.Discount).Must(p => p >= 0);
        }
    }
}
