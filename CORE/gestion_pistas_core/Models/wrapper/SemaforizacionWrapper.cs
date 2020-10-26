using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class SemaforizacionWrapper
    {
        public  int Id { get; set; }
        public string Proceso { get; set; }
        public string Estado { get; set; }
        public string SubEstado { get; set; }
        public string Descripcion { get; set; }
        public decimal TiempoIni { get; set; }
        public string Color { get; set; }
        public decimal? TiempoFin { get; set; }
        public string EstadoRegistro { get; set; }
    }
}
