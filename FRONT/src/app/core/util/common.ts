import { environment } from 'src/environments/environment';

export class Commons{

    static encript( original:string ){
        const subOne=original.substring(0,2);
        const subTwo=original.substring(2,original.length);
        return btoa( this.convertCharToNumber(subOne)+  environment.comodin + this.convertCharToNumber(subTwo) );
    }

    static unencript(encript:string){
        //console.log( "===>unencript " +  encript + "   " + atob(encript) + "  " + atob( encript ).replace(environment.comodin,"_" ) );
        let local = atob( encript ).replace(environment.comodin,"_" );
        return this.convertNumberToChar(local);
    }

    static convertCharToNumber(stringToDo:string){
        if(stringToDo && stringToDo!=="" ){
            let replaceString="";
            for(var i=0;i<stringToDo.length;i++){
                replaceString=replaceString+ stringToDo.charCodeAt(i);
                if( i<stringToDo.length-1 ){
                    replaceString=replaceString+ "_";
                }
            }
            return replaceString;
        } else {
            return "";
        }
    }

    static convertNumberToChar(encripted:string){
        //console.log( "===>unconvertNumberToCharencript " + encripted );
        if( encripted && encripted!=="" ){
            let local=encripted;
            let lsplited=local.split("_");
            let newString="";
            if( lsplited && lsplited.length>0 ){
                for(var i=0;i<lsplited.length;i++){
                    newString=newString+String.fromCharCode(Number(lsplited[i]));
                }
            }
            return newString;
        } else {
            return "";
        }
        
    }
}

