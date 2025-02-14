using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Specifications;

public interface IUserSpecification<T>
{
    bool IsSatisfiedBy(T entity);
}
