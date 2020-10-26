using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class PiArchivoWrapper
    {
        public int Id { get; set; }
        public string Extension { get; set; }
        public string Tipo { get; set; }
        public string ObjectId { get; set; }
        public string Nombre { get; set; }
        public int IdPista { get; set; }
    }
}
