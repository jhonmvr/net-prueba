using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class ActividadLaboralWrapper
    {
        public new int Id { get; set; }
        public int IdPista { get; set; }
        public int? IdSolicitante { get; set; }
        public int? IdDireccion { get; set; }
        public string EmpresaTrabajo { get; set; }
        public decimal? EmpresaActividadId { get; set; }
        public string EmpresaActividadNombre { get; set; }
        public decimal? EmpresaTipoRelacionId { get; set; }
        public string EmpresaTipoRelacion { get; set; }
        public string Cargo { get; set; }
        public string TelefonoTrabajo { get; set; }
        public decimal? TiempoTrabajoAnio { get; set; }
        public decimal? TiempoTrabajoMes { get; set; }
        public string Tipo { get; set; }
        public int? IdRelPer { get; set; }

        public DireccionWrapper IdDireccionNavigation { get; set; }
    }
}
