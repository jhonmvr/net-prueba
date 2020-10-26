using System;
using System.Collections.Generic;

namespace gestion_pistas_core.Models
{
    public partial class TbPiParametro : Entity<int>
    {
        public new int Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string CaracteristicaUno { get; set; }
        public string CaracteristicaDos { get; set; }
        public string Catalogo { get; set; }
        public string SubCatalogo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? Orden { get; set; }
    }
}
