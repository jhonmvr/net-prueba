using gestion_pistas_core.Models;
using gestion_pistas_core.Models.util;
using gestion_pistas_core.Models.wrapper;
using gestion_pistas_core.repository;
using gestion_pistas_core.repository.imp;
using gestion_pistas_core.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static gestion_pistas_core.Models.util.Constantes;

namespace gestion_pistas_core.Services
{
    
    public class GestionPistasService
    {
       
        private readonly IParametroRepository parametroRepository;
      


        public GestionPistasService( IParametroRepository parametroRepository)
        {
           
            this.parametroRepository = parametroRepository;
        }

      



        #region Parametro
        public async Task<TbPiParametro> findParametroByNombre(string nombre)
        {
            return await parametroRepository.findByNombre(nombre);
        }
        public async Task<List<TbPiParametro>> findAllParametro()
        {
            return (List<TbPiParametro>)await parametroRepository.GetAll();
        }
        public async Task<List<NacionalidadWrapper>> findNacionalidadByParametro(string catalogo)
        {
            return (List<NacionalidadWrapper>) await parametroRepository.getParametrosByNacionalidad(catalogo);
        }
        public async Task<TbPiParametro> findByIdParametro(int idParametro)
        {
            return await parametroRepository.GetById(idParametro);
        }

        public async Task<TbPiParametro> CreateParametro(TbPiParametro entity)
        {
            return (TbPiParametro) await parametroRepository.Create(entity);
        }

        public async Task UpdateParametro(int id, TbPiParametro entity)
        {
            await parametroRepository.Update(id, entity);
        }

        public async Task DeleteParametro(int id)
        {
            await parametroRepository.Delete(id);
        }

       

        public async Task<List<TbPiParametro>> getParametrosByCatalogo(string catalogo)
        {
            return await parametroRepository.getParametrosByCatalogo(catalogo);
        }

        public async Task<List<TbPiParametro>> getParametroBySubCatalogo(string catalogo, string subcatalogo)
        {
            return await parametroRepository.findBySubCatalogo(catalogo, subcatalogo);
        }

        public async Task<List<TbPiParametro>> getParametroByNombre(string nombre)
        {
            return await parametroRepository.findByNombreCom(nombre);
        }

        #endregion

     

    }



}
