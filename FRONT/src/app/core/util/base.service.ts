import { HttpHeaders, HttpParams, HttpClient, HttpErrorResponse } from '@angular/common/http';
import { PistaNoticeService } from '../services/pista-notice.service';
import { throwError } from 'rxjs';
import { environment } from '../../../environments/environment';


export class BaseService {


  public headers: HttpHeaders;
  public options;
  public services: any;
  public params: HttpParams;
  public http: HttpClient;


  public apiUrlResourcesPista: string;
  public apiUrlGeneric: string;
  public apiUrlMail:string;
  public apiUrlLoging:string;
  public tiempoRefresh: string;

  public setParameter() {
    this.apiUrlResourcesPista = environment.urlCorePista; //'https://localhost:44343/gestion-pista-rest/resources/';
    this.apiUrlGeneric = environment.apiUrlGeneric;
    this.apiUrlMail =environment.apiUrlMail;
    this.apiUrlLoging = environment.apiUrlLoging;
    this.tiempoRefresh = '2';
  }

  HandleError(error: any, pistaNoticeService: PistaNoticeService) {
    console.log(error);
    if (error instanceof HttpErrorResponse) {
      if (error.status != 200) {
        if (error.error) {
          pistaNoticeService.setNotice(error.error.message, 'error');
        } else {
          pistaNoticeService.setNotice(error.error, 'error');

        }
      }
    } else if (JSON.stringify(error).indexOf("codError") > 0) {
      let b = error.error;
      pistaNoticeService.setNotice(b.msgError, 'error');
    } else if (error.error instanceof Blob) {
      pistaNoticeService.setNotice("NO SE ENCUENTRA O NO EXISTE ", 'error');
    } else if (error.error instanceof ProgressEvent) {
      pistaNoticeService.setNotice("NO SE PUEDE ACCEDER AL SERVICIO REVISE SU CONEXIÓN A INTERNET O VPN", 'error');
    }

    let errorMessage = '';
    if (error.status === 401) {
      errorMessage = 'Error: ' + error.statusText;
      //this.securityService.logout();
    } else if (error.status === 403) {
      errorMessage = 'Error: ' + error.statusText;
      //this.securityService.resetPasswordRequired();
    } else if (error.status === 500) {
      errorMessage = 'Error: ' + error.statusText;
    } else {
      errorMessage = 'Error: ' +(error.error === undefined || error.error === null ? 
        (error.mensaje === undefined || error.mensaje === null ? error : error.mensaje): 
        (error.error.mensaje === undefined || error.error.mensaje === null ? '' : error.error.mensaje))
        ;
    }

    return throwError(errorMessage);

  }
  public setHeaderWithSegToken(token: string) {
    this.headers = new HttpHeaders({
      'Content-Type': 'application/json',
      Accept: 'application/json',
      Authorization: 'Bearer ' + token
    });
  }
  dataURItoBlob(dataURI) {
    var byteString = atob(dataURI);
    var ab = new ArrayBuffer(byteString.length);
    var ia = new Uint8Array(ab);
    for (var i = 0; i < byteString.length; i++) {
        ia[i] = byteString.charCodeAt(i);
    }
    var blob = new Blob([ab]);
    return blob;
  }
}