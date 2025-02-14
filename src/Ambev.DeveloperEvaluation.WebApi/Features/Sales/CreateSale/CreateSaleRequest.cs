using Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Represents a request to create a new sale in the system.
    /// </summary>
    public class CreateSaleRequest
    {
        /// <summary>
        /// Gets or sets the date sale. Must be equal to or greater than today.
        /// </summary>
        public DateTime DateSale { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets  the customer to the sale. Must be different from null or empty
        /// </summary>
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets  the total sale amount to the sale. Must be greater than zero.
        /// </summary>
        public decimal TotaSaleAmount { get; set; } = 0m;

        /// <summary>
        /// Gets or sets  the total sale amount to the sale.
        /// </summary>
        public string Branch { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets  the status to the sale.
        /// </summary>
        public bool Cancelled { get; set; } = false;

        /// <summary>
        /// Gets or sets  the products to the sale. Must be different from null or empty
        /// </summary>
        public List<CreateProductRequest> Products { get; set; } = [];
    }
}
