using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class EstructuraDuplicadoWrapper
    {
        private EstructuraDuplicado pistaNuevoJson;
        private EstructuraDuplicado pistaexistenteJson;
        
        [JsonPropertyName("pistaNuevoJson")]
        public EstructuraDuplicado PistaNuevoJson { get => pistaNuevoJson; set => pistaNuevoJson = value; }

        [JsonPropertyName("pistaexistenteJson")]
        public EstructuraDuplicado PistaexistenteJson { get => pistaexistenteJson; set => pistaexistenteJson = value; }

		public override string ToString()
		{
			StringBuilder str = new StringBuilder("EstructuraDuplicadoWrapper:[");
			str.Append(PistaNuevoJson);
			str.Append(",");
            str.Append(PistaexistenteJson);
            str.Append(",");
            return str.ToString();
		}
	}
}
