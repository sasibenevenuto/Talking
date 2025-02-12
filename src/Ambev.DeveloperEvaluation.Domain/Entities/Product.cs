using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Represents a product in the system.
    /// </summary>
    public class Product : BaseEntity, IProduct
    {
        /// <summary>
        /// Gets the sale id to the product information.
        /// </summary>
        public string SaleId { get; set; } = string.Empty;

        /// <summary>
        /// Gets the amount to the product information.
        /// </summary>
        public int Amount { get; set; } = 0;

        /// <summary>
        /// Gets the unit price to the product information.
        /// </summary>
        public decimal UnitPrice { get; set; } = 0m;

        /// <summary>
        /// Gets the discount to the product information.
        /// </summary>
        public decimal Discount { get; set; } = 0m;

        /// <summary>
        /// Gets the total amount to the product information.
        /// </summary>
        public decimal TotalAmount { get; set; } = 0m;

        /// <summary>
        /// Gets the status to the product information.
        /// </summary>
        public bool Cancelled { get; set; } = false;      

        /// <summary>
        /// Gets the unique identifier of the product.
        /// </summary>
        /// <returns>The products ID as a string.</returns>
        string IProduct.Id => Id.ToString();

        /// <summary>
        /// Gets the sale Id.
        /// </summary>
        /// <returns>The sale id.</returns>
        string IProduct.SaleId => SaleId;

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <returns>The amount.</returns>
        int IProduct.Amount => Amount;

        /// <summary>
        /// Gets the unit price.
        /// </summary>
        /// <returns>The unit price.</returns>
        decimal IProduct.UnitPrice => UnitPrice;

        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <returns>The discount.</returns>
        decimal IProduct.Discount => Discount;

        /// <summary>
        /// Gets the total amount.
        /// </summary>
        /// <returns>The amount.</returns>
        decimal IProduct.TotalAmount => TotalAmount;

        /// <summary>
        /// Gets the cancelled.
        /// </summary>
        /// <returns>The cancelled.</returns>
        bool IProduct.Cancelled => Cancelled;
    }
}
