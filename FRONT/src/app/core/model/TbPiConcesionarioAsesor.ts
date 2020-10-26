import { TbPiAsesorComercial } from './TbPiAsesorComercial';

export class TbPiConcesionariaAsesor{
    id : string;
    concesionarioCod: string;
    concesionarioNombre  : string;
    sucursalCod: string;
    sucursalNombre  : string;
    asesorConcesionario: string;
    asesorId: string;
    asesorNombre: string;
    asesor: TbPiAsesorComercial;
    estado : string;
    fechaCreacion:string;
    fechaActualizacion :string;
    usuarioCreacion:string;
    usuarioActualizacion :string;
    constructor(){
        this.asesor = new TbPiAsesorComercial();
    }
}