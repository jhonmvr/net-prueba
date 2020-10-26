using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
   
    public class SolicitudListWrapper
    {
        public int id { get; set; }
        public string numeroSolicitud {get; set; }
        public string ciSolicitante { get; set; }
        public string nombreSolicitante { get; set; }
        public string perfilCliente { get; set; }
        public string score { get; set; }
        public string concesionario { get; set; }
        public string sucursal { get; set; }
        public string estado { get; set; }
        public string proceso { get; set; }
        public string subEstado { get; set; }
        public string asesor { get; set; }
        public string asesorConsecionario { get; set; }
        public decimal? pvp { get; set; }
        public decimal? entrada { get; set; }
        public decimal? plazo { get; set; }
        public decimal? montoFinanciar { get; set; }
        public decimal? coutaTotal { get; set; }
        public decimal? capacidadPago { get; set; }
        public TimeSpan? tiempo { get; set; }
        public string alerta { get; set; }
        public string notificacion { get; set; }
        public DateTime? fechaSolicitud { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public string owner { get; set; }
        public string gestor { get; set; }

        public int vinculacion { get; set; }
        public string estadoPeso { get;  set; }
        public string subEstadoPeso { get;  set; }
    }
}
