using System.Linq.Expressions;

namespace HealingPaws.Services.Interfaces.Services;

public interface IBaseService<TEntity, TRequestModel, TResponseModel>
{
    Task<TResponseModel> GetByIdAsync(int id);
    Task<IEnumerable<TResponseModel>> GetAllAsync();
    Task<IEnumerable<TResponseModel>> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TResponseModel> CreateAsync(TRequestModel requestModel);
    Task<bool> UpdateAsync(int id, TRequestModel requestModel);
    Task<bool> DeleteAsync(int id);
}
