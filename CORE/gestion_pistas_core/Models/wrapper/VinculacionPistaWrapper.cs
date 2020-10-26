using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class VinculacionPistaWrapper
    {
        public int Id { get; set; }
        public int IdPista { get; set; }
        public int IdPistaRelacionada { get; set; }
    }
}
