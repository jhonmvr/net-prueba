using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class AsesorComercialWrapper
    {

        public new int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string Mail { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string UsuarioActualizacion { get; set; }

    }
}
