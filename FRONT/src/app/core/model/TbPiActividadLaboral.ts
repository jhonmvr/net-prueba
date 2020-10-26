import { TbPiPDirecccion } from './TbPiDireccion';

export class TbPiActividadLaboral{
        id : string;
        idPista : string;
        idSolicitante : string;
        direccion : string;
        empresaTrabajo : string;
        empresaActividadId : string;
        empresaActividadNombre : string;
        empresaTipoRelacionId : string;
        empresaTipoRelacion : string;
        cargo : string;
        telefonoTrabajo : string;
        tiempoTrabajoAnio : string;
        tiempoTrabajoMes : string;
        tipo : string;
        idRelPer : string;

        idDireccionNavigation: TbPiPDirecccion;
         tbPiPista  : any;
         tbPiRelacionPersona  : any;
         tbPiSolicitante  : any;


    constructor(){

    this.idDireccionNavigation = new TbPiPDirecccion();
        
    }
}