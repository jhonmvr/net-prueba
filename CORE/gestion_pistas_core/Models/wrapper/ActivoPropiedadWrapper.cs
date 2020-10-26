using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class ActivoPropiedadWrapper
    {
        public int Id { get; set; }
        public int IdPista { get; set; }
        public string TipoActivo { get; set; }
        public string VehiculoModelo { get; set; }
        public string VehiculoMarca { get; set; }
        public decimal? VehiculoAnio { get; set; }
        public decimal? VehiculoValor { get; set; }
        public string InmuebleTipo { get; set; }
        public bool? InmuebleHipotecado { get; set; }
        public decimal? InmuebleValor { get; set; }
        public string InmuebleDireccion { get; set; }
        public string InversionTipo { get; set; }
        public string InversionInstitucion { get; set; }
        public decimal? InversionValor { get; set; }
        public bool? OtroActivo { get; set; }
        public string OtroDescripcion { get; set; }
        public decimal? OtroValor { get; set; }

        public PistaWrapper IdPistaNavigation { get; set; }
    }
}
