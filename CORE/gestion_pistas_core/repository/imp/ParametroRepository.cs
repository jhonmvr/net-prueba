using gestion_pistas_core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion_pistas_core.Models.util;
using gestion_pistas_core.Models.wrapper;

namespace gestion_pistas_core.repository.imp
{
    public class ParametroRepository : GenericRepository<TbPiParametro, int>, IParametroRepository
    {
        readonly pistasContext ctx;

        public ParametroRepository(pistasContext dbContext) : base(dbContext)
        {
            this.ctx = dbContext;
        }

        /// <summary>
        /// Rogger Lindao 25 Junio 2020 Lista los parametros por tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public async Task<List<TbPiParametro>> getParametrosByCatalogo(string catalogo)
        {
            try
            {
                List<TbPiParametro> listaParametros = await (from parametro in ctx.TbPiParametro
                                                             where parametro.Catalogo == catalogo
                                                             select parametro).ToListAsync();

                return listaParametros;
            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.MSG_ERROR_BUSQUEDA, "CATALOGO", e);
            }
        }

        public async Task<List<TbPiParametro>> findByNombreCom(string nombre)
        {
            try
            {
                List<TbPiParametro> listaParametros = await (from parametro in ctx.TbPiParametro
                                                             where parametro.SubCatalogo == nombre
                                                             select parametro).ToListAsync();
                return listaParametros;
            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.MSG_ERROR_BUSQUEDA, "VALOR", e);
            }
        }

        public async Task<List<TbPiParametro>> findBySubCatalogo(string catalogo,string subcatalogo)
        {
            try
            {
                List<TbPiParametro> listaParametros = await (from parametro in ctx.TbPiParametro
                                                             where parametro.Catalogo == catalogo && parametro.SubCatalogo == subcatalogo
                                                             select parametro).ToListAsync();

                return listaParametros;
            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.MSG_ERROR_BUSQUEDA, "CATALOGO", e);
            }
        }

        /// <summary>
        /// <param name="catalogo"></param>
        /// <returns></returns>
        /// </summary>
        public async Task<List<NacionalidadWrapper>> getParametrosByNacionalidad(string catalogo)
        {
            try
            {

                List<NacionalidadWrapper> query = await(from parametro in ctx.TbPiParametro
                                                  where parametro.Catalogo == catalogo
                                                  select new NacionalidadWrapper
                                                  {
                                                      Nombre = parametro.Valor
                                                  }
                                                     ).ToListAsync(); 
               

                return query;
            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.MSG_ERROR_BUSQUEDA, "NACIONALIDAD", e);
            }
        }

        public async Task<TbPiParametro> findByNombre(string nombre)
        {
            try
            {
                return  await ctx.Set<TbPiParametro>()
                 .AsNoTracking()
                 .FirstOrDefaultAsync(e => e.Nombre.Equals(nombre));

            }
            catch (RelativeException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw new RelativeException(Constantes.MSG_ERROR_BUSQUEDA, "CATALOGO", e);
            }
        }

    }
}
