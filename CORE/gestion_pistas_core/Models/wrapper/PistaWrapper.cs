using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class PistaWrapper
    {
        public int? Id { get; set; }
        public string ConcesionarioCod { get; set; }
        public int? ConcesionarioId { get; set; }
        public string ConcesionarioNombre { get; set; }
        public decimal? ConcesionarioOrdenamiento { get; set; }
        public string ConcesionarioAsesorNombre { get; set; }

        public string Owner { get; set; }
        public string SucursalCod { get; set; }
        public int? SucursalId { get; set; }
        public string SucursalName { get; set; }
        public decimal? SucursalOrdenamiento { get; set; }
        public int? AsesorId { get; set; }
        public string AsesorNombre { get; set; }
        public string AsesorMail { get; set; }
        public string VehiculoTipo { get; set; }
        public int? VehiculoMarcaId { get; set; }
        public string VehuculoMarcaNombre { get; set; }
        public string VehiculoModeloNombre { get; set; }
        public int? VehiculoAnio { get; set; }
        public decimal? VehiculoVentaTotal { get; set; }
        public decimal? VehiculoValorEntrada { get; set; }
        public decimal? VehiculoValorAccesorio { get; set; }
        public string VehiculoFrecuenciaPago { get; set; }
        public decimal? VehiculoPlazo { get; set; }
        public decimal? MontoFinanciar { get; set; }
        public decimal? Pvp { get; set; }
        public int? IdSolicitante { get; set; }
        public decimal? IngresoSueldoMensual { get; set; }
        public decimal? IngresoOtro { get; set; }
        public decimal? IngresoSueldoMensualConyuge { get; set; }
        public decimal? IngresoOtroConyuge { get; set; }
        public decimal? IngresoTotal { get; set; }
        public decimal? TotalPasivo { get; set; }
        public decimal? TotalActivos { get; set; }
        public decimal? TotalPatrimonio { get; set; }
        public decimal? CapacidadPago { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public TimeSpan? Hora { get; set; }
        public string UsuarioCreacion { get; set; }
        public string NumeroPista { get; set; }
        public string Estado { get; set; }
        public string SubEstado { get; set; }
        public DateTime? FechaGestion { get; set; }

        public string Proceso { get; set; }
        public decimal? VehiculoValorEntradaMinima { get; set; }

        public string ConcesionarioAsesorMail { get; set; }
        public string ConcesionarioMail { get; set; }
        public decimal? PlazoCore { get; set; }
        public string NombreCore { get; set; }
        public decimal? CuotaTotalCore { get; set; }
        public decimal? EntradaCore { get; set; }
        public string SolicitudCore { get; set; }
        public decimal? MontoCore { get; set; }
        public decimal? CuotaTotalMes { get; set; }
        public string subjet { get; set; }
        public string body { get; set; }
        public AsesorComercialWrapper Asesor { get; set; }
        public SolicitanteWrapper IdSolicitanteNavigation { get; set; }
        public List<ActividadLaboralWrapper> TbPiActividadLaboral { get; set; }
        public List<ActivoPropiedadWrapper> TbPiActivoPropiedad { get; set; }
        public List<PiArchivoWrapper> TbPiArchivo { get; set; }
        public List<PistaDireccionWrapper> TbPiPistaDireccion { get; set; }
        public List<PistaRelacionPersonaWrapper> TbPiPistaRelacionPersona { get; set; }
        public List<ReferenciaBancariaWrapper> TbPiReferenciaBancaria { get; set; }
        public List<VinculacionPistaWrapper> TbPiVinculacionPistaIdPistaNavigation { get; set; }
        public List<VinculacionPistaWrapper> TbPiVinculacionPistaIdPistaRelacionadaNavigation { get; set; }
    }
}
