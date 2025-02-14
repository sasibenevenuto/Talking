using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
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
        /// Gets the status to the sale information.
        /// </summary>
        public bool Cancelled { get; set; } = false;

        /// <summary>
        /// Gets the products of the sale.
        /// </summary>
        /// <returns>The products a list.</returns>
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

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

        /// <summary>
        /// Performs validation of the sale entity using the SaleValidator rules.
        /// </summary>
        /// <returns>
        /// A <see cref="ValidationResultDetail"/> containing:
        /// - IsValid: Indicates whether all validation rules passed
        /// - Errors: Collection of validation errors if any rules failed
        /// </returns>
        /// <remarks>
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">DateSale not null</list>
        /// <list type="bullet">Customer not null</list>
        /// <list type="bullet">TotaSaleAmount not nullt</list>
        /// <list type="bullet">Products not nullt</list>
        /// </remarks>
        public ValidationResultDetail Validate()
        {
            var validator = new SaleValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }

        /// <summary>
        /// Activates the user account.
        /// Changes the user's status to Active.
        /// </summary>
        public void Activate()
        {
            Cancelled = false;
        }

        /// <summary>
        /// Deactivates the user account.
        /// Changes the user's status to Inactive.
        /// </summary>
        public void Deactivate()
        {
            Cancelled = true;
        }
    }
}
