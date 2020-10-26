using gestion_pistas_core.Models;
using gestion_pistas_core.Models.util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.repository.imp
{
    public class GenericRepository<TEntity, T> : IGenericRepository<TEntity, T>
        where TEntity : Entity<T>
    {
        readonly pistasContext cx;
        public GenericRepository(pistasContext context)
        {
            this.cx = context;
        }

        public async Task<Object> Create(TEntity entity)
        {
            try
            {
                var x = await cx.Set<TEntity>().AddAsync(entity);
                await cx.SaveChangesAsync();
                return x;
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.ERROR_CODE_CREATE, "ERROR AL CREAR", e);
            }

        }

        public async Task Delete(T id)
        {
            try
            {
                var entity = await GetById(id);
                cx.Set<TEntity>().Remove(entity);
                await cx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.ERROR_CODE_DELETE, "ERROR AL BORRAR", e);
            }
        }

        public async Task<IList<TEntity>> GetAll()
        {
            try
            {
                return await cx.Set<TEntity>().ToListAsync();
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.ERROR_CODE_READ, "ERROR AL BUSCAR", e);
            }

        }

        public async Task<TEntity> GetById(T id)
        {

            try
            {
                return await cx.Set<TEntity>()
               .AsNoTracking()
               .FirstOrDefaultAsync(e => e.Id.Equals(id));
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.ERROR_CODE_READ, "ERROR AL BUSCAR", e);
            }
        }

        public async Task Update(T id, TEntity entity)
        {


            try
            {
                var x = await cx.Set<TEntity>()
               .AsNoTracking()
               .FirstOrDefaultAsync(e => e.Id.Equals(id));

                entity.Id = id;
                cx.Set<TEntity>().Update(entity);
                await cx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.ERROR_CODE_UPDATE, "ERROR AL ACTUALIZAR", e);
            }

        }
    }
}
