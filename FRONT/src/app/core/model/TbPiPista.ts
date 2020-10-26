import { TbPiSolicitante } from './TbPiCliente';
import { TbPiActividadLaboral } from './TbPiActividadLaboral';
import { TbPiReferenciaBancaria } from './TbPiReferenciaBancaria';
import { TbPiActivoPropiedad } from './TbPiActivoPropiedad';
import { TbPiAsesorComercial } from './TbPiAsesorComercial';

export class TbPiPista{
   id:string;
   subject:string;
   body:string;
   concesionarioId:string;
   concesionarioNombre:string;
   concesionarioAsesorNombre:string;
   concesionarioOrdenamiento:string;
   concesionarioCod : string;
   sucursalCod:string;
   hora:string;
   owner:string;
   sucursalId:string;
   sucursalName:string;
   sucursalOrdenamiento:string;
   asesor: TbPiAsesorComercial;
   asesorId:string;
   asesorNombre:string;
   asesorMail:string;
   vehiculoTipo:string;
   vehiculoMarcaId:string;
   vehuculoMarcaNombre:string;
   vehiculoModeloNombre:string;
   vehiculoAnio:string;
   vehiculoValor:string;
   vehiculoVentaTotal:string;
   vehiculoValorEntrada:string;
   vehiculoValorEntradaMinima:string;
   vehiculoValorAccesorio:string;
   vehiculoFrecuenciaPago:string;
   vehiculoPlazo:string;
   montoFinanciar : string;
   idSolicitante:string;
   ingresoSueldoMensual:string;
   ingresoOtro:string;
   ingresoSueldoMensualConyuge:string;
   ingresoOtroConyuge:string;
   ingresoTotal:string;
   totalPasivo:string;
   totalActivos:string;
   totalPatrimonio:string;
   capacidadPago : string;
   fechaCreacion:string;
   fechaSolicitud:string;
   usuarioCreacion:string;
   numeroPista :string;
   estado :string;
   subEstado :string;
   pvp:string;

   concesionarioMail:string;
   concesionarioAsesorMail:string;
   plazoCore:string;
   nombreCore:string;
   cuotaTotalCore:string;
   solicitudCore:string;
   montoCore:string;
   cuotaTotalMes:string;
   entradaCore:string;
   valorVehiculo:string;
   
   idSolicitanteNavigation:TbPiSolicitante;
   tbPiActivoPropiedad:TbPiActivoPropiedad[];
   tbPiArchivo:any;
   tbPiPistaDireccion:any;
   tbPiPistaRelacionPersona:any;
   tbPiReferenciaBancaria: TbPiReferenciaBancaria[];
   tbPiVinculacionPistaIdPistaNavigation:any;
   tbPiVinculacionPistaIdPistaRelacionadaNavigation:any;


   constructor(){

    this.idSolicitanteNavigation = new TbPiSolicitante();
    //this.tbPiReferenciaBancaria = new TbPiReferenciaBancaria;
   }

 }