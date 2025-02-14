namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductRequest
    {
        /// <summary>
        /// Gets or sets the sale id to the product. Must be different from null or empty.
        /// </summary>
        public Guid? SaleId { get; set; } = Guid.Empty;

        /// <summary>
        /// Gets or sets the amount to the product. Must be greater than zero.
        /// </summary>
        public int Amount { get; set; } = 0;

        /// <summary>
        /// Gets or sets the unit price to the product. Must be greater than zero.
        /// </summary>
        public decimal UnitPrice { get; set; } = 0m;

        /// <summary>
        /// Gets or sets the discount to the product.
        /// </summary>
        public decimal Discount { get; set; } = 0m;

        /// <summary>
        /// Gets or sets the total amount to the product.
        /// </summary>
        public decimal TotalAmount { get; set; } = 0m;

        /// <summary>
        /// Gets or sets the status to the product.
        /// </summary>
        public bool Cancelled { get; set; } = false;
    }
}
