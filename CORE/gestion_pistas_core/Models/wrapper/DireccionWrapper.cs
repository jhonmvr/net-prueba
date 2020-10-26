using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class DireccionWrapper
    {
        public int Id { get; set; }
        public string CallePrincipal { get; set; }
        public string CalleSecundario { get; set; }
        public string Numero { get; set; }
        public string TipoActividad { get; set; }
        public string TipoDomicilio { get; set; }
        public string CodigoPostal { get; set; }
        public int IdSolicitante { get; set; }
        public string Referencia { get; set; }
        public string DireccionCompleta { get; set; }
        public string Telefono { get; set; }
        public string NombreProvincia { get; set; }
        public string NombreCanton { get; set; }
        public string NombreParroquia { get; set; }
        public string Barrio { get; set; }
    }
}
