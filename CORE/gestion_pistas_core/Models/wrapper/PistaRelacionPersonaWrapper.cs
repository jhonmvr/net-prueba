using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class PistaRelacionPersonaWrapper
    {
        public int Id { get; set; }
        public int IdRelPer { get; set; }
        public int IdPista { get; set; }
        public int IdSolicitante { get; set; }


        public RelacionPersonaWrapper IdRelPerNavigation { get; set; }
    }
}
