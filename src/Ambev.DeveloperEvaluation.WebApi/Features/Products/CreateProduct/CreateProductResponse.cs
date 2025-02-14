namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// API response model for CreateProduct operation
    /// </summary>
    public class CreateProductResponse
    {
        /// <summary>
        /// The product's full sale id
        /// </summary>
        public Guid SaleId { get; set; } = Guid.Empty;

        /// <summary>
        /// The product's full amount
        /// </summary>
        public int Amount { get; set; } = 0;

        /// <summary>
        /// The product's full unit price
        /// </summary>
        public decimal UnitPrice { get; set; } = 0m;

        /// <summary>
        /// The product's full discount
        /// </summary>
        public decimal Discount { get; set; } = 0m;

        /// <summary>
        /// The product's full total amount
        /// </summary>
        public decimal TotalAmount { get; set; } = 0m;

        /// <summary>
        /// The product's full cancelled
        /// </summary>
        public bool Cancelled { get; set; } = false;
    }
}
