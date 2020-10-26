using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class EstructuraDuplicado
    {


        [JsonPropertyName("sucursal")]
        public string sucursal { get ; set; }

        [JsonPropertyName("numeroCedulaCliente")]
        public string numeroCedulaCliente { get; set; }

        [JsonPropertyName("estadoCivilCliente")]
        public string estadoCivilCliente { get; set; }

        [JsonPropertyName("sueldoMensualTitular")]
        public double sueldoMensualTitular { get; set; }

        [JsonPropertyName("otrosIngresosTitular")]
        public double otrosIngresosTitular { get; set; }

        [JsonPropertyName("sueldoMensualConyuge")]
        public double sueldoMensualConyuge { get ; set ; }

        [JsonPropertyName("otrosIngresosConyuge")]
        public double otrosIngresosConyuge { get ; set ; }

        [JsonPropertyName("totalIngresosTitularConyuge")]
        public double totalIngresosTitularConyuge { get ; set ; }

        [JsonPropertyName("valorBienAdquirirCliente")]
        public double valorBienAdquirirCliente { get ; set ; }

        [JsonPropertyName("procesado")]
        public bool procesado { get ; set ; }

        [JsonPropertyName("estado")]
        public string estado { get ; set ; }

        [JsonPropertyName("task-id")]
        public string concesionario { get ; set ; }

        [JsonPropertyName("codigo")]
        public string codigo { get; set ; }

        [JsonPropertyName("cedula")]
        public string cedula { get ; set; }

        [JsonPropertyName("cantidadPistas")]
        public int cantidadPistas { get; set ; }

		public override string ToString()
		{
			StringBuilder str = new StringBuilder("EstructuraDuplicado:[");			
			str.Append(sucursal);
			str.Append(",");
			str.Append(numeroCedulaCliente);
			str.Append(",");
			str.Append(estadoCivilCliente);
			str.Append(",");
			str.Append(otrosIngresosTitular);
			str.Append(",");
			str.Append(sueldoMensualTitular);
			str.Append(",");
			str.Append(sueldoMensualConyuge);
			str.Append(",");
			str.Append(otrosIngresosConyuge);
			str.Append(",");
			str.Append(totalIngresosTitularConyuge);
			str.Append(",");
			str.Append(valorBienAdquirirCliente);
			str.Append(",");
			str.Append(procesado);
			str.Append(",");
			str.Append(estado);
			str.Append(",");
			str.Append(concesionario);
			str.Append(",");
			str.Append(codigo);
			str.Append(",");
			str.Append(cedula);
			str.Append(",");
			str.Append(cantidadPistas);
			return str.ToString();
		}
			
	}
}
