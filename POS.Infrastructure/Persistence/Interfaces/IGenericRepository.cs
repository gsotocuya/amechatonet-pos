using System.Linq.Expressions;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Infrastructure.Persistence.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<bool> RegisterAsync(T entity);
    Task<bool> EditAsync(T entity);
    Task<bool> RemoveAsync(int id);
    IQueryable<T> GetEntityQuery(Expression<Func<T, bool >>? filter = null );

    IQueryable<TDto> Ordering<TDto>(BasePaginationRequest request, IQueryable<TDto> queryable, bool pagination = false)
        where TDto : class;

}