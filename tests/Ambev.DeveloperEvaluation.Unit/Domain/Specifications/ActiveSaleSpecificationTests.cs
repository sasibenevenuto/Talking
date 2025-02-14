using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Specifications;
using Ambev.DeveloperEvaluation.Unit.Domain.Specifications.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Specifications
{
    public class ActiveSaleSpecificationTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(10, true)]
        [InlineData(22, false)]
        public void IsSatisfiedBy_ShouldValidateUserStatus(int amount, bool expectedResult)
        {
            // Arrange
            var sale = ActiveSaleSpecificationTestData.GenerateSale(amount);
            var specification = new ActiveSaleSpecification();

            // Act
            var result = specification.DiscountSpecification(sale);

            // Assert
            Assert.True(string.IsNullOrWhiteSpace(result) == expectedResult);
        }
    }
}
