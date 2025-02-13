using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct
{
    /// <summary>
    /// Command for creating a new product.
    /// </summary>
    /// <remarks>
    /// This command is used to capture the required data for creating a product, 
    /// including SaleId, Amount, UnitPrice, Discount, TotalAmount and Cancelled. 
    /// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
    /// that returns a <see cref="CreateProductResult"/>.
    /// 
    /// The data provided in this command is validated using the 
    /// <see cref="CreateProductCommandValidator"/> which extends 
    /// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
    /// populated and follow the required rules.
    /// </remarks>
    public class CreateProductCommand : IRequest<CreateProductResult>
    {
        /// <summary>
        /// Gets or sets the sale id to the product information.
        /// </summary>
        public Guid SaleId { get; set; } = Guid.Empty;

        /// <summary>
        /// Gets or sets the amount to the product information.
        /// </summary>
        public int Amount { get; set; } = 0;

        /// <summary>
        /// Gets or sets the unit price to the product information.
        /// </summary>
        public decimal UnitPrice { get; set; } = 0m;

        /// <summary>
        /// Gets or sets the discount to the product information.
        /// </summary>
        public decimal Discount { get; set; } = 0m;

        /// <summary>
        /// Gets or sets the total amount to the product information.
        /// </summary>
        public decimal TotalAmount { get; set; } = 0m;

        /// <summary>
        /// Gets or sets the status to the product information.
        /// </summary>
        public bool Cancelled { get; set; } = false;
    }
}
