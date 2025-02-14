using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData
{
    /// <summary>
    /// Provides methods for generating test data using the Bogus library.
    /// This class centralizes all test data generation to ensure consistency
    /// across test cases and provide both valid and invalid data scenarios.
    /// </summary>
    public static class SaleTestData
    {
        /// <summary>
        /// Configures the Faker to generate valid User entities.
        /// The generated users will have valid:
        /// - DateSale (valid format)
        /// - Customer (valid not null)
        /// - TotaSaleAmount (valid format)
        /// - Branch (valid format)
        /// - Cancelled (valid format)        /// </summary>
        private static readonly Faker<Sale> SaleFaker = new Faker<Sale>()
            .RuleFor(u => u.DateSale, f => f.DateTimeReference)
            .RuleFor(u => u.Customer, f => f.Lorem.Word())
            .RuleFor(u => u.TotaSaleAmount, f => f.PickRandom(0m, decimal.MaxValue))
            .RuleFor(u => u.Branch, f => f.Lorem.Word())
            .RuleFor(u => u.Cancelled, f => f.PickRandom(true, false));

        /// <summary>
        /// Generates a valid Sale entity with randomized data.
        /// The generated sale will have all properties populated with valid values
        /// that meet the system's validation requirements.
        /// </summary>
        /// <returns>A valid User entity with randomly generated data.</returns>
        public static Sale GenerateValidSale()
        {
            return SaleFaker.Generate();
        }
    }
}
