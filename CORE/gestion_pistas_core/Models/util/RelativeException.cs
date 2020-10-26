using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.util
{
    public class RelativeException : Exception
    {
        public RelativeException()
        {
        }

        public RelativeException(String codigo,string message,Object T)
            : base(codigo+" "+message+" "+ T.GetType().Name)
        {
        }
        public RelativeException(String codigo, string message)
            : base(codigo + " " + message )
        {
        }
        public RelativeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
