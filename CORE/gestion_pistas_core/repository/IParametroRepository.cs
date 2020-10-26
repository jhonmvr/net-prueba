using gestion_pistas_core.Models;
using gestion_pistas_core.Models.wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.repository
{
    public interface IParametroRepository : IGenericRepository<TbPiParametro, int>
    {
        /// <summary>
        /// Rogger Lindao 25 Junio 2020 Lista los parametros por tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        Task<List<TbPiParametro>> getParametrosByCatalogo(string catalogo);
        Task<List<TbPiParametro>> findByNombreCom(string nombre);
        Task<List<TbPiParametro>> findBySubCatalogo(string catalogo, string subcatalogo);
        Task<List<NacionalidadWrapper>> getParametrosByNacionalidad(string catalogo);
        Task<TbPiParametro> findByNombre(string nombre);
    }
}
