using System;
using System.Collections.Generic;

namespace gestion_pistas_core.Models
{
    public partial class Persona: Entity<int>
    {
        public new int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
    }
}
