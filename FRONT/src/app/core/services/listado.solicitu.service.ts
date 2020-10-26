import { Injectable } from '@angular/core';
import { BaseService } from '../util/base.service';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { tap } from 'rxjs/operators';
import { PistaNoticeService } from './pista-notice.service';
import { PaginateWrapper } from '../model/wrapper/PaginateWrapper';
import { environment } from 'src/environments/environment';
import { Commons } from '../util/common';

@Injectable({
  providedIn: 'root'
})
export class SolicitudListService extends BaseService {

  https: HttpClient;
  headerss: HttpHeaders;
  paramss: HttpParams;

  constructor(_http: HttpClient, private pistaNoticeService: PistaNoticeService) {

    super();
    this.https = _http;

  }



  public findAllSemaforizacion(){
    return this.https.get(this.apiUrlResourcesPista+"semaforizacionRestController/listAllEntities",{headers:this.headerss}).pipe(
      tap( // Log the result or error
        (data: any) => data,
        error => { this.HandleError(error, this.pistaNoticeService); }
      )
    );
  }

  public findSolicitudByParams(sort, paginator, fechaInicion, fechaFin, estado, concesionario, sucursal, titular, ciTitular, solicitud, perfil) {
    console.log("===> listado de estados a buscar " + estado);
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("fechaInicion", fechaInicion);
    this.paramss = this.paramss.set("fechaFin", fechaFin);
    //this.paramss = this.paramss.set("estado", estado);
    this.paramss = this.paramss.set("concesionario", concesionario);
    this.paramss = this.paramss.set("sucursal", sucursal);
    this.paramss = this.paramss.set("titular", titular);
    this.paramss = this.paramss.set("ciTitular", ciTitular);
    this.paramss = this.paramss.set("solicitud", solicitud);
    this.paramss = this.paramss.set("perfil", perfil);
    if(Commons.unencript( localStorage.getItem(environment.rolKey)) !='SUPERVISOR'){
      this.paramss = this.paramss.set("user", Commons.unencript( localStorage.getItem(environment.userKey) ));
    }
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    paginateWrapper.estado = estado;
    console.log("======xxx>",paginateWrapper);
    return this.https.post(
      this.apiUrlResourcesPista + "pistaRestController/findSolicitudByParams", paginateWrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public loadNotificacionesPista( idPista ){
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("collection", environment.mongoColNotif);
    const wrapper=[
      {
        "etiqueta":"idRelacionado",
        "valor":idPista,
        "operador": "eq"
      }
    ]
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.post(environment.apiUrlListMongo,wrapper,options).pipe(
      tap( // Log the result or error
        (data: any) => data,
        error => { this.HandleError(error, this.pistaNoticeService); }
      )
    );
  }
  

}