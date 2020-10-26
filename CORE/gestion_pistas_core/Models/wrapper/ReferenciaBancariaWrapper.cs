using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class ReferenciaBancariaWrapper
    {
        public int Id { get; set; }
        public string Ifi { get; set; }
        public string CuentaCorriente { get; set; }
        public string CuentaAhorro { get; set; }
        public int IdPista { get; set; }
    }
}
