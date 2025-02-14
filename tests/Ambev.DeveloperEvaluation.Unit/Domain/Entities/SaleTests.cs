using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities
{
    /// <summary>
    /// Contains unit tests for the Sale entity class.
    /// Tests cover status changes and validation scenarios.
    /// </summary>
    public class SaleTests
    {
        /// <summary>
        /// Tests that when a suspended sale is activated, their status changes to Active.
        /// </summary>
        [Fact(DisplayName = "Sale status should change to Active when activated")]
        public void Given_SuspendedSale_When_Activated_Then_StatusShouldBeActive()
        {
            // Arrange
            var sale = SaleTestData.GenerateValidSale();
            sale.Cancelled = false;

            // Act
            sale.Activate();

            // Assert
            Assert.True(sale.Cancelled);
        }

        /// <summary>
        /// Tests that when an active Sale is suspended, their status changes to Suspended.
        /// </summary>
        [Fact(DisplayName = "Sale status should change to Suspended when suspended")]
        public void Given_ActiveSale_When_Suspended_Then_StatusShouldBeSuspended()
        {
            // Arrange
            var sale = SaleTestData.GenerateValidSale();
            sale.Cancelled = false;

            // Act
            sale.Deactivate();

            // Assert
            Assert.False(sale.Cancelled);
        }

        /// <summary>
        /// Tests that validation passes when all Sale properties are valid.
        /// </summary>
        [Fact(DisplayName = "Validation should pass for valid Sale data")]
        public void Given_ValidSaleData_When_Validated_Then_ShouldReturnValid()
        {
            // Arrange
            var sale = SaleTestData.GenerateValidSale();

            // Act
            var result = sale.Validate();

            // Assert
            Assert.True(result.IsValid);
            Assert.Empty(result.Errors);
        }

        /// <summary>
        /// Tests that validation fails when Sale properties are invalid.
        /// </summary>
        [Fact(DisplayName = "Validation should fail for invalid Sale data")]
        public void Given_InvalidSaleData_When_Validated_Then_ShouldReturnInvalid()
        {
            // Arrange
            var sale = new Sale
            {
                DateSale = new DateTime(0,0,0), // Invalid: Date
                Customer = "", // Invalid: empty
                TotaSaleAmount = 0, // Invalid: quantity
                Branch = string.Empty, 
                Cancelled = false
            };

            // Act
            var result = sale.Validate();

            // Assert
            Assert.False(result.IsValid);
            Assert.NotEmpty(result.Errors);
        }
    }
}
