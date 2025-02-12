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
    /// Represents a sale in the system.
    /// </summary>
    public class Sale : BaseEntity, ISale
    {
        /// <summary>
        /// Gets the date sale to the sale information.
        /// </summary>
        public DateTime DateSale { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets the customer to the sale information.
        /// </summary>
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// Gets the total sale amount to the sale information.
        /// </summary>
        public decimal TotaSaleAmount { get; set; } = 0m;

        /// <summary>
        /// Gets the total sale amount to the sale information.
        /// </summary>
        public string Branch { get; set; } = string.Empty;

        /// <summary>
        /// Gets the statuc to the sale information.
        /// </summary>
        public bool Cancelled { get; set; } = false;

        /// <summary>
        /// Gets the date sale.
        /// </summary>
        /// <returns>The date sale.</returns>
        DateTime ISale.DateSale => DateSale;

        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <returns>The customer.</returns>
        string ISale.Customer => Customer;

        /// <summary>
        /// Gets the total sale amount.
        /// </summary>
        /// <returns>The total sale amount.</returns>
        decimal ISale.TotaSaleAmount => TotaSaleAmount;

        /// <summary>
        /// Gets the branch.
        /// </summary>
        /// <returns>The branch.</returns>
        string ISale.Branch => Branch;
        

        bool ISaleCancelled => Cancelled;

        /// <summary>
        /// Gets the unique identifier of the sale.
        /// </summary>
        /// <returns>The sales ID as a string.</returns>
        string ISale.Id => Id.ToString();
    }
}
