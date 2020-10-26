import { AbstractControl } from "@angular/forms";


export function ValidateCedula(control: AbstractControl) {
      if (control.value != null || typeof control.value === 'string' && control.value.length !== 0) {

        let cedula:string = control.value;
        if(cedula.length>10 && cedula.length<14){
            cedula = cedula.substring(0,10);
        }

        if(cedula.length == 10){
            let digito_region = cedula.substring(0,2);
            if( Number.parseInt( digito_region) >= 1 && Number.parseInt(digito_region )<=24 ){
                let ultimo_digito   = cedula.substring(9,10);
                let total=0;
                for(let i = 0; i < 9; i++){
                    if (i%2 == 0) {
                        let aux = Number.parseInt(cedula.charAt(i) )* 2;
                        if (aux > 9) aux -= 9;
                        total += aux;
                    } else {
                        total += parseInt(cedula.charAt(i));
                    }
                }
                let primer_digito_suma = String(total).substring(0,1);
                let decena = (parseInt(primer_digito_suma) + 1)  * 10;
                let digito_validador = decena - total;
                if(digito_validador == 10) {
                    digito_validador = 0
                }

                if(digito_validador == Number.parseInt(ultimo_digito)){
                    return null;

                }else{
                    return {'cedulaIncorecta':true};
                }

            }


        }else {
            return {'cedulaIncorecta':true};
        }

    } else {
    return {'cedulaIncorecta':true};
    }


}
