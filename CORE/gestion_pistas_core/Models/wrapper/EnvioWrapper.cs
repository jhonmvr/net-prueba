using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    [Serializable()]
    public class EnvioWrapper : ISerializable
    {
        public PistaBpmWrapper datoPista { get; set; }
        public string estadoProceso { get; set; }
        public string jsonContentCore { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
        }
    }
}
