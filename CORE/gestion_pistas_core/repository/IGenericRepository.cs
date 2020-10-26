using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.repository
{
    public interface IGenericRepository<TEntity,T> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();

        Task<TEntity> GetById(T id);

        Task<Object> Create(TEntity entity);

        Task Update(T id, TEntity entity);

        Task Delete(T id);
    }
}
