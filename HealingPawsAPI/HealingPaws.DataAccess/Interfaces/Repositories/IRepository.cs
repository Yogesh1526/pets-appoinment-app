using HealingPaws.DataAccess.Entities;
using System.Linq.Expressions;

namespace HealingPaws.DataAccess.IRepositories;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id, Expression<Func<T, object>>[] includeProperties);
    Task<T> GetByIdWithNoIncludeAsync(int id);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>>[] includeProperties);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task<T> CreateAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> RemoveAsync(T entity);
}
