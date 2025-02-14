using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Unit.Application.TestData;
using AutoMapper;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Application
{
    /// <summary>
    /// Contains unit tests for the <see cref="CreateSaleHandler"/> class.
    /// </summary>
    public class CreateSaleHandlerTests
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly CreateSaleHandler _handler;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserHandlerTests"/> class.
        /// Sets up the test dependencies and creates fake data generators.
        /// </summary>
        public CreateSaleHandlerTests()
        {
            _saleRepository = Substitute.For<ISaleRepository>();
            _productRepository = Substitute.For<IProductRepository>();
            _mapper = Substitute.For<IMapper>();
            _handler = new CreateSaleHandler(_saleRepository, _productRepository, _mapper);
        }

        /// <summary>
        /// Tests that a valid sale creation request is handled successfully.
        /// </summary>
        [Fact(DisplayName = "Given valid sale data When creating user Then returns success response")]
        public async Task Handle_ValidRequest_ReturnsSuccessResponse()
        {
            // Given
            var command = CreateSaleHandlerTestData.GenerateValidCommand();

            var sale = new Sale
            {
                Id = Guid.NewGuid(),
                DateSale = command.DateSale,
                Customer = command.Customer,
                TotaSaleAmount = command.TotaSaleAmount,
                Branch = command.Branch,
                Cancelled = command.Cancelled,
                Products = _mapper.Map<List<Product>>(command.Products)
            };

            var result = new CreateSaleResult
            {
                Id = sale.Id,
            };


            _mapper.Map<Sale>(command).Returns(sale);
            _mapper.Map<CreateSaleResult>(sale).Returns(result);

            _saleRepository.CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>())
                .Returns(sale);


            // When
            var createUserResult = await _handler.Handle(command, CancellationToken.None);

            // Then
            createUserResult.Should().NotBeNull();
            createUserResult.Id.Should().Be(sale.Id);
            await _saleRepository.Received(1).CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>());
        }

        /// <summary>
        /// Tests that an invalid sale creation request throws a validation exception.
        /// </summary>
        [Fact(DisplayName = "Given invalid sale data When creating user Then throws validation exception")]
        public async Task Handle_InvalidRequest_ThrowsValidationException()
        {
            // Given
            var command = new CreateSaleCommand(); // Empty command will fail validation

            // When
            var act = () => _handler.Handle(command, CancellationToken.None);

            // Then
            await act.Should().ThrowAsync<FluentValidation.ValidationException>();
        }


        /// <summary>
        /// Tests that the mapper is called with the correct command.
        /// </summary>
        [Fact(DisplayName = "Given valid command When handling Then maps command to user entity")]
        public async Task Handle_ValidRequest_MapsCommandToUser()
        {
            // Given
            var command = CreateSaleHandlerTestData.GenerateValidCommand();
            var sale = new Sale
            {
                Id = Guid.NewGuid(),
                DateSale = command.DateSale,
                Customer = command.Customer,
                TotaSaleAmount = command.TotaSaleAmount,
                Branch = command.Branch,
                Cancelled = command.Cancelled,
                Products = _mapper.Map<List<Product>>(command.Products)
            };

            _mapper.Map<Sale>(command).Returns(sale);
            _saleRepository.CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>())
                .Returns(sale);

            // When
            await _handler.Handle(command, CancellationToken.None);

            // Then
            _mapper.Received(1).Map<Sale>(Arg.Is<CreateSaleCommand>(c =>
                c.DateSale == command.DateSale &&
                c.Customer == command.Customer &&
                c.TotaSaleAmount == command.TotaSaleAmount &&
                c.Branch == command.Branch &&
                c.Cancelled == command.Cancelled &&
                c.Products == command.Products));
        }
    }
}
