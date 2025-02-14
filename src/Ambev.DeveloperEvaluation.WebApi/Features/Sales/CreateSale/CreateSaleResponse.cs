namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// API response model for CreateSale operation
    /// </summary>
    public class CreateSaleResponse
    {
        /// <summary>
        /// The unique identifier of the created sale
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The sale's date
        /// </summary>
        public DateTime DateSale { get; set; } = DateTime.Now;

        /// <summary>
        /// The sale's customer
        /// </summary>
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// The sale's total amount
        /// </summary>
        public decimal TotaSaleAmount { get; set; } = 0m;

        /// <summary>
        /// The sale's branch
        /// </summary>
        public string Branch { get; set; } = string.Empty;

        /// <summary>
        /// The sale's cancelled
        /// </summary>
        public bool Cancelled { get; set; } = false;
    }
}
