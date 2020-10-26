import { TbPiReferencia } from './TbPiReferencia';
import { TbPiRelacionPersona } from './TbPiRelacionPersona';
import { TbPiActividadLaboral } from './TbPiActividadLaboral';
import { TbPiPDirecccion } from './TbPiDireccion';

export class TbPiSolicitante{

    id:string;
    nombreCompleto:string;
    cedula:string;
    estadoCivil:string;
    telefonoCelular:string;
    cantidadCarga:string;
    mail:string;
    fechaNacimiento:string;
    nacionalidad:string;
    perfil:string;
    score:string;
    concesionarioAsesorNombre:string; 

    tbPiPista:any; 
    //tbReferenciaPersonal:TbPiReferencia [];
    tbPiActividadLaboral:TbPiActividadLaboral [];
    tbPiDireccion:TbPiPDirecccion [];
    tbPiRelacionPersona : TbPiRelacionPersona[];
    constructor(init?: Partial<TbPiSolicitante>){ 
    //this.tbPiActividadLaboral = new TbPiActividadLaboral();
    //this.tbPiRelacionPersona = new TbPiRelacionPersona();
   
    //this.tbPiDireccion = new TbPiPDirecccion();

    }
}