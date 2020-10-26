using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class PistaDireccionWrapper
    {
        public int Id { get; set; }
        public int IdDireccion { get; set; }
        public int IdPista { get; set; }
        public int IdSolicitante { get; set; }
    }
}
