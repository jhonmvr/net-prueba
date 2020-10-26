import { Injectable } from '@angular/core';
import { BaseService } from '../../util/base.service';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { PistaNoticeService } from '../pista-notice.service';
import { tap } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
  })
  export class LongingService extends BaseService {
  

    https: HttpClient;
    headerss: HttpHeaders;
    paramss: HttpParams;
    
    constructor(_http: HttpClient , private pistaNoticeService: PistaNoticeService ) {

      super();
      this.https = _http;

    }



    logingWS(user,pass){
      //console.log("entra a logingWS",user," ",pass)
      this.paramss = new HttpParams();
      
      this.paramss = this.paramss.set('username',user);
      this.paramss = this.paramss.set('password',pass);
      let options = { headers: this.headerss, params: this.paramss };
      return this.https.get(
        this.apiUrlLoging, options).pipe(
          tap( // Log the result or error
            (data: any) => data,
            error => { this.HandleError(error, this.pistaNoticeService); }
          )
        );
    }
   
    
  }