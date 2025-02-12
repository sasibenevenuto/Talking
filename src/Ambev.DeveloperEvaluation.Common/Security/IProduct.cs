using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Common.Security
{
    public interface IProduct
    {
        /// <summary>
        /// Obtém o identificador único do produto.
        /// </summary>
        /// <returns>O ID do produto como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o identificador único da venda que o produto está associado.
        /// </summary>
        /// <returns>O ID da venda como uma string.</returns>
        public string SaleId { get; }

        /// <summary>
        /// Obtém a quantidade do produto na venda.
        /// </summary>
        /// <returns>A Quantidade do produto como inteiro.</returns>
        public int Amount { get; }

        /// <summary>
        /// Obtém o preço unitátio do produto na venda.
        /// </summary>
        /// <returns>O Preço unitário do produto como decimal.</returns>
        public decimal UnitPrice { get; }

        /// <summary>
        /// Obtém o desconto do produto na venda.
        /// </summary>
        /// <returns>O desconto do produto como decimal.</returns>
        public decimal Discount { get; }

        /// <summary>
        /// Obtém o valor total do produto na venda.
        /// </summary>
        /// <returns>O valor total do produto como decimal.</returns>
        public decimal TotalAmount { get; }

        /// <summary>
        /// Obtém se o produto está cancelado na venda.
        /// </summary>
        /// <returns>O produto cancelado na venda como booleano.</returns>
        public bool Cancelled { get; }
    }
}
