using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using gestion_pistas_core.Models;
using gestion_pistas_core.Models.util;
using gestion_pistas_core.Models.wrapper;
using gestion_pistas_core.Services;
using gestion_pistas_core.Util;
using Microsoft.AspNetCore.Mvc;

namespace gestion_pistas_core.Controllers

{
 
 
    [Route("gestion-pista-rest/resources/[controller]RestController")]
    [ApiController]
    public class ParametroController : ControllerBase
    {

        private readonly GestionPistasService gps;
        public ParametroController(GestionPistasService gestionParametros) 
        {
            gps = gestionParametros;
        }

        [HttpGet("getParametroByCatalogo")]
        public async Task<List<TbPiParametro>> getParametroByCatalogo([FromQuery(Name = "catalogo")] string catalogo)
        {
            try
            {
                List<TbPiParametro> ListaParametros = await gps.getParametrosByCatalogo(catalogo);
                return ListaParametros;
            }
            catch(RelativeException e)
            {
                throw e;
            }
            
        }
        [HttpGet("findByNombre")]
        public async Task<ActionResult<TbPiParametro>> findByNombreAsync([FromQuery(Name = "nombre")] string nombre)
        {
            try
            {
                return await gps.findParametroByNombre(nombre);
            }
            catch (RelativeException e)
            {
                return BadRequest(new { mensaje =e.Message });
            }

        }
        [HttpGet("getParametroBySubCatalogo")]
        public async Task<List<TbPiParametro>> getParametroBySubCatalogo([FromQuery(Name = "catalogo")] string catalogo, [FromQuery(Name = "subcatalogo")] string subcatalogo)
        {
            try
            {
                List<TbPiParametro> ListaParametros = await gps.getParametroBySubCatalogo(catalogo,subcatalogo);
                return ListaParametros;
            }
            catch (RelativeException e)
            {
                throw e;
            }

        }

        [HttpGet("getParametroByNombre")]
        public async Task<List<TbPiParametro>> getParametroByNombre([FromQuery(Name = "nombre")] string nombre)
        {
            try
            {
                List<TbPiParametro> ListarParametros = await gps.getParametroByNombre(nombre);
                return ListarParametros;
            }
            catch (RelativeException e)
            {
                throw e;
            }
        }

        [HttpGet("getEntity")]
        public async Task<TbPiParametro> getEntity([FromQuery(Name = "id")] int id)
        {
            return await gps.findByIdParametro(id);
        }

        [HttpGet("listAllEntities")]
        public async Task<List<TbPiParametro>> listAllEntities()
        {
            return await gps.findAllParametro();
        }

     
 

        [HttpGet("getNacionalidadByCatalogo")]
        public async Task<List<NacionalidadWrapper>> getNacionalidadByCatalogo([FromQuery(Name = "catalogo")] string catalogo)
        {
            try
            {
                List<NacionalidadWrapper> ListaParametros = await gps.findNacionalidadByParametro(catalogo);
                return ListaParametros;
            }
            catch (RelativeException e)
            {
                throw e;
            }

        }

        [HttpGet("getDiffBetweenDateInicioActual")]
        public async Task<YearMonthDay> getDiffBetweenDateInicioActual([FromQuery(Name = "fechaInicio")] string fechaInicio, [FromQuery(Name = "formato")] string formato)
        {
            try
            {
                YearMonthDay ymd = new YearMonthDay();
                ymd = MfcUtil.calculateEdad(MfcUtil.formatSringToDate(fechaInicio, formato));
                return ymd;
            }
            catch (RelativeException e)
            {
                throw e;
            }

        }

        

    }
}