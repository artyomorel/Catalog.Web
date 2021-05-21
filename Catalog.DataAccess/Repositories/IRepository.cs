using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}