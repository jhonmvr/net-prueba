using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class SolicitanteWrapper
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string EstadoCivil { get; set; }
        public string TelefonoCelular { get; set; }
        public int? CantidadCarga { get; set; }
        public string Mail { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Perfil { get; set; }
        public string Score { get; set; }

        public List<ActividadLaboralWrapper> TbPiActividadLaboral { get; set; }
        public List<DireccionWrapper> TbPiDireccion { get; set; }
        public List<PistaWrapper> TbPiPista { get; set; }
        public List<PistaDireccionWrapper> TbPiPistaDireccion { get; set; }
        public List<PistaRelacionPersonaWrapper> TbPiPistaRelacionPersona { get; set; }
        public List<RelacionPersonaWrapper> TbPiRelacionPersona { get; set; }
        
    }
}
