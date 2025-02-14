using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Specifications
{
    public interface ISaleSpecification<T>
    {
        string DiscountSpecification(T entity);
    }
}
