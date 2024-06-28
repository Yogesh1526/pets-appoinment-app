using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace HealingPaws.DataAccess.Extensions;
public static class IQueryableExtensions
{
    public static IQueryable<T> IncludeProperties<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includeProperties) where T : class
    {
        if (includeProperties != null)
        {
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        return query;
    }
}
