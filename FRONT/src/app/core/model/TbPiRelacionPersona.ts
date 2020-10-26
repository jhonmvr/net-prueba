import { TbPiActividadLaboral } from './TbPiActividadLaboral';

export class TbPiRelacionPersona{

        id:string;
        idSolicitante:string;
        nombreCompleto:string;
        cedula :string;
        nacionalidad:string;
        conyuge:any;
        parentesco:string;
        telefono:string;
        fechaNacimiento:string;
        direccion:string;
        tipo:string;
        estado:string;
        edad:string;
        tbPiActividadLaboral : TbPiActividadLaboral[];
         constructor(){
          //this.tbPiActividadLaboral = new TbPiActividadLaboral();
        }
}