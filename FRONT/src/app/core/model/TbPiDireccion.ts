import { TbPiSolicitante } from './TbPiCliente';

export class TbPiPDirecccion{

     id : string;
     IdDireccion : any;
     IdPista : any;
     IdSolicitante : any;
     callePrincipal: string;
     calleSecundario: string;
     numero: string;
     tipoActividad: string;
     tipoDomicilio: string;
     codigoPostal: string;
     idSolicitante: string;
     referencia: string;
     direccionCompleta: string;
     telefono: string;
     nombreProvincia: string;
     nombreCanton: string;
     nombreParroquia: string;
     barrio: string;
 

    TbPiSolicitante  : TbPiSolicitante;



   constructor(init?: Partial<TbPiPDirecccion>){
      
}

}