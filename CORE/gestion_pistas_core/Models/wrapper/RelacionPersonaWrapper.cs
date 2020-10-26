using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class RelacionPersonaWrapper
    {
        public int Id { get; set; }
        public int IdSolicitante { get; set; }
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public bool? Conyuge { get; set; }
        public string Parentesco { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
         public string Estado { get; set; }
        public int? Edad { get; set; }
        public List<ActividadLaboralWrapper> TbPiActividadLaboral { get; set; }
    }
}
