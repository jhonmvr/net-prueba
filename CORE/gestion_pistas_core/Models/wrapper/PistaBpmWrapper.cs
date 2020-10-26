using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
	
	public class PistaBpmWrapper 
	{
		private string id;
		private string idProceso;
		private string codigo;
		private string sucursal;
		private string cedula;
		private string estadoCivil;
		private decimal sueldoMensual;
		private decimal otrosIngresos;
		private decimal sueldoMensualConyuge;
		private decimal otrosIngresosConyuge;
		private decimal totalIngreso;
		private decimal ventaTotal;
		private decimal entrada;
		private decimal valorAccesorios;
		private string frecuenciaPago;
		private string plazo;
		private string estado;
		private string notificacion;
		private string concesionario;
		private string numeroSolicitud;
		private Boolean procesado;
		private Int64 cantidadPistas;
		private string idRelacionado;
		private string objectId;
		private string vendedor;
		private string lugarFecha;
		private string modelo;
		private decimal montoFinanciar;
		private Int64 anio;
		private decimal taza;
		private decimal cuotaMensual;
		private string primerApellido;
		private string segundoApellido;
		private string nombres;
		private string empresaId;
		private string empresaTrabajo;
		private string telefonoTrabajo;
		private string tiempoTrabajo;
		private string cargoTrabajo;
		private string direccionTrabajo;
		private string tipoRelacionLaboral;
		private string jubilado;
		private string cedulaConyuge;
		private string primerApellidoConyuge;
		private string segundoApellidoConyuge;
		private string primerNombreConyuge;
		private string edadConyuge;
		private string nacionalidadConyuge;
		private string telefonoTrabajoConyuge;
		private string tiempoTrabajoConyuge;
		private string cargoTrabajoConyuge;
		private string direccionTrabajoConyuge;
		private string tipoRelacionLaboralConyuge;
		private string jubiladoConyuge;
		private string empresaTrabajoConyuge;
		private string direccionDomicilio;
		private string parroquiaDomicilio;
		private string telefonoDomicilio;
		private string celularDomicilio;
		private string bancoRefBan;
		private string cuentaRefBan;
		private string tipoCuentaRefBan;
		private string nombreRefPer;
		private string relacionRefPer;
		private string telefonoRefPer;
		private string nombreDosRefPer;
		private string relacionDosRefPer;
		private string telefonoDosRefPer;
		private decimal casaActivo;
		private decimal vehiculoActivo;
		private decimal terrenoActivo;
		private decimal otroActivo;
		private decimal totalActivo;
		private decimal cxpBancoPasivo;
		private decimal cxpProveedorPasivo;
		private decimal tarjetaCreditoPasivo;
		private decimal otroPasivo;
		private decimal totalPasivo;
		private decimal activoPatrimonio;
		private decimal pasivosPatrimonio;
		private decimal totalPatrimonio;

		//nuevos campos core
		private string alerta;
		private string mailVendedor;
		private string plazoCore;
		private string perfilClienteCore;
		private string scoreCore;
		private string solicitudCore;
		private decimal entradaMinimaCore;
        private decimal montoCore;
		private string nombreCore;
		private decimal cuentaTotalCore;
		private decimal capacidadPagoCore;
		private string subEstado;
		private string numeroPistaCore;
		private string proceso;
		private string mailAsesor;

		//nuevos campos
		private decimal vehiculoValor;
		private string subject;
		private string body;

		public string Id { get; set; }
		public string IdProceso { get; set; }
		public string Codigo { get; set; }
		public string Sucursal { get; set; }
		public string Cedula { get; set; }
		public string EstadoCivil { get; set; }
		public decimal? SueldoMensual { get; set; }
		public decimal? OtrosIngresos { get; set; }
		public decimal? SueldoMensualConyuge { get; set; }
		public decimal? OtrosIngresosConyuge { get; set; }
		public decimal? TotalIngreso { get; set; }
		public decimal? VentaTotal { get; set; }
		public decimal? Entrada { get; set; }
		public decimal? ValorAccesorios { get; set; }
		public string FrecuenciaPago { get; set; }
		public string Plazo { get; set; }
		public string Estado { get; set; }
		public string Notificacion { get; set; }
		public string Concesionario { get; set; }
		public string NumeroSolicitud { get; set; }
		public bool? Procesado { get; set; }
		public long? CantidadPistas { get; set; }
		public string IdRelacionado { get => idRelacionado; set => idRelacionado = value; }

		public string Proceso { get => proceso; set => proceso = value; }
		public string ObjectId { get => objectId; set => objectId = value; }
		public string Vendedor { get => vendedor; set => vendedor = value; }
		public string LugarFecha { get => lugarFecha; set => lugarFecha = value; }
		public string Modelo { get => modelo; set => modelo = value; }
		public decimal? MontoFinanciar { get; set; }
		public long? Anio { get; set; }
		public decimal? Taza { get; set; }
		public decimal? CuotaMensual { get; set; }
		public string PrimerApellido { get; set; }
		public string SegundoApellido { get; set; }
		public string Nombres { get; set; }
		public string EmpresaId { get; set; }
		public string EmpresaTrabajo { get; set; }
		public string TelefonoTrabajo { get; set; }
		public string TiempoTrabajo { get; set; }
		public string CargoTrabajo { get; set; }
		public string DireccionTrabajo { get; set; }
		public string TipoRelacionLaboral { get; set; }
		public string Jubilado { get; set; }
		public string CedulaConyuge { get; set; }
		public string PrimerApellidoConyuge { get; set; }
		public string SegundoApellidoConyuge { get; set; }
		public string PrimerNombreConyuge { get; set; }
		public string EdadConyuge { get; set; }
		public string NacionalidadConyuge { get; set; }
		public string TelefonoTrabajoConyuge { get; set; }
		public string TiempoTrabajoConyuge { get; set; }
		public string CargoTrabajoConyuge { get; set; }
		public string DireccionTrabajoConyuge { get; set; }
		public string TipoRelacionLaboralConyuge { get; set; }
		public string JubiladoConyuge { get; set; }
		public string EmpresaTrabajoConyuge { get; set; }
		public string DireccionDomicilio { get; set; }
		public string ParroquiaDomicilio { get; set; }
		public string TelefonoDomicilio { get; set; }
		public string CelularDomicilio { get; set; }
		public string BancoRefBan { get; set; }
		public string CuentaRefBan { get; set; }
		public string TipoCuentaRefBan { get; set; }
		public string NombreRefPer { get; set; }
		public string RelacionRefPer { get; set; }
		public string TelefonoRefPer { get; set; }
		public string NombreDosRefPer { get; set; }
		public string RelacionDosRefPer { get; set; }
		public string TelefonoDosRefPer { get; set; }
		public decimal? CasaActivo { get; set; }
		public decimal? VehiculoActivo { get; set; }
		public decimal? TerrenoActivo { get; set; }
		public decimal? OtroActivo { get; set; }
		public decimal? TotalActivo { get; set; }
		public decimal? CxpBancoPasivo { get; set; }
		public decimal? CxpProveedorPasivo { get; set; }
		public decimal? TarjetaCreditoPasivo { get; set; }
		public decimal? OtroPasivo { get; set; }
		public decimal? TotalPasivo { get; set; }
		public decimal? ActivoPatrimonio { get; set; }
		public decimal? PasivosPatrimonio { get; set; }
		public decimal? TotalPatrimonio { get; set; }
		//nuevos campos core
		public string Alerta { get; set; }
		public string PlazoCore { get; set; }
		public string MailVendedor { get; set; }
		public string PerfilClienteCore { get; set; }
		public string ScoreCore { get; set; }
		public string SolicitudCore { get; set; }
		public decimal? EntradaMinimaCore { get; set; }
		public decimal? MontoCore { get; set; }
		public string NombreCore { get; set; }
		public decimal? CuentaTotalCore { get; set; }
		public decimal? CapacidadPagoCore { get; set; }
		public string SubEstado { get; set; }
		public string MailAsesor { get; set; }

		//nuevos campos
		public decimal? VehiculoValor { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }


		public string NumeroPistaCore { get => numeroPistaCore; set => numeroPistaCore = value; }
	}
}
