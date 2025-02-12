using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de uma venda no sistema.
    /// </summary>
    public interface ISale
    {
        /// <summary>
        /// Obtém o identificador único da venda.
        /// </summary>
        /// <returns>O ID da venda como uma string.</returns>
        public string Id { get; }
        /// <summary>
        /// Obtém a data da venda.
        /// </summary>
        /// <returns>A data da venda como um datetime.</returns>
        public DateTime DateSale { get; }
        /// <summary>
        /// Obtém o cliente da venda.
        /// </summary>
        /// <returns>O Cliente da venda como uma string.</returns>
        public string Customer { get; }
        /// <summary>
        /// Obtém o valor total da venda.
        /// </summary>
        /// <returns>O valor total da venda como um decimal.</returns>
        public decimal TotaSaleAmount { get; }
        /// <summary>
        /// Obtém o local da venda.
        /// </summary>
        /// <returns>O local da venda como uma string.</returns>
        public string Branch { get; }
       
        /// <summary>
        /// Obtém se a venda está cancelado.
        /// </summary>
        /// <returns>A venda cancelado como booleano.</returns>
        public bool Cancelled { get; }
    }
}
