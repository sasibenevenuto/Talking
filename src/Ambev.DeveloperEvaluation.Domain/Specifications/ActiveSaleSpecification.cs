using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Specifications
{
    public class ActiveSaleSpecification : ISaleSpecification<Sale>
    {
        string returnMessage = string.Empty;
        public string DiscountSpecification(Sale sale)
        {
            foreach (var product in sale.Products)
            {
                int item = product.Amount;
                
                switch (item)
                {                    
                    case < 4:
                        product.Discount = 0;
                        break;
                    case < 10:
                        product.Discount = 10;
                        break;
                    case <= 20:
                        product.Discount = 20;
                        break;
                    case > 20:
                        returnMessage = "It's not possible to sell above 20 identical items";
                        break;
                }
              
            }
            return returnMessage;
        }
    }
}
