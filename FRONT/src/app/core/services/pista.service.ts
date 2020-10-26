import { Injectable } from '@angular/core';
import { BaseService } from '../util/base.service';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { tap } from 'rxjs/operators';
import { PistaNoticeService } from './pista-notice.service';
import { Page } from '../model/page';
import { TbPiPista } from '../model/TbPiPista';
import { Observable } from 'rxjs';
import { PaginateWrapper } from '../model/wrapper/PaginateWrapper';
import { TbPiConcesionariaAsesor } from '../model/TbPiConcesionarioAsesor';
import { TbPiAsesorComercial } from '../model/TbPiAsesorComercial';
import { TbPiSemaforizacion } from '../model/TbPiSemaforizacion';
import { TbPiOrdenamiento } from '../model/TbPiOrdenamiento';
import { environment } from 'src/environments/environment';
import { Commons } from '../util/common';

@Injectable({
  providedIn: 'root'
})
export class PistaService extends BaseService {


  https: HttpClient;
  headerss: HttpHeaders;
  paramss: HttpParams;

  constructor(_http: HttpClient, private pistaNoticeService: PistaNoticeService) {

    super();
    this.https = _http;

  }

  public allPaginatedUrl(/* page: Page, */ url: string) {

    /*   this.setSearchParams(page); */
    //console.log("==> parametros obtenidos " +  this.paramss.toString() );
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(url, options).pipe(
      tap( // Log the result or error
        (data: any) => data,
        error => { this.HandleError(error, this.pistaNoticeService); }
      )
    );
  }

  public getAllPaginatedByProvincia(idProvincia: string): Observable<any> {

    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idProvincia", "" + idProvincia);
    //console.log("==> parametros obtenidos " +  this.params.toString() );
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "cantonRestController/getEntityByProvincia",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }


  public getAllParroquiaByID(provinciaid: string, cantonid: string) {

    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idProvincia", provinciaid);
    this.paramss = this.paramss.set("idCanton", cantonid);
    //console.log("==> parametros obtenidos " +  this.params.toString() );
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "parroquiaRestController/getEntityByProvinciaCanton",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public getParameterByTipo(catalogo: string) {
    //console.log("ingresa a service");
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("catalogo", catalogo);

    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "parametroRestController/getParametroByCatalogo",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public getNacionalidadByTipo(catalogo: string) {
    //console.log("ingresa a service");
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("catalogo", catalogo);

    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "parametroRestController/getNacionalidadByCatalogo",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findSubCatalogo(catalogo: string, subcatalogo: string) {
    // console.log("ingresa a service");
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("catalogo", catalogo);
    this.paramss = this.paramss.set("subcatalogo", subcatalogo);

    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "ParametroRestController/getParametroBySubCatalogo",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  findByIdPista(idPista){
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("id", idPista);
    let options = { headers: this.headerss, params: this.paramss };
   
    return this.https.get(
      this.apiUrlResourcesPista + "pistaRestController/getEntity", options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findSubCatalogoNom(nombre: string) {
    console.log("ingresa a service");
    console.log(nombre);
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("nombre", nombre);

    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "ParametroRestController/getParametroByNombre",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findAsesorByCodSucursal(codSucursal: string) {
    console.log("ingresa a service");
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("codSucursal", codSucursal);


    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "ConcesionarioAsesorRestController/getConcesionarioAsesorBySucursal",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findByPkurl(id: string) {
    //console.log("ingresa a service");
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("id", id);

    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "PistaRestController/getEntity",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }


  vincularPista(idPista: string, idPistaGestion: string) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idPista", idPista);
    this.paramss = this.paramss.set("idPistaGestion", idPistaGestion);
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.post(this.apiUrlResourcesPista + "pistaRestController/callVinculacionPista", null,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  reProcesar(idPista: string) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idPistaGestion", idPista);
    this.paramss = this.paramss.set("user", Commons.unencript(localStorage.getItem(environment.userKey)));
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.post(this.apiUrlResourcesPista + "pistaRestController/reProcesar", null,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public getPistaByIdentificacionTitular(paginator, identificacion: string) {
    //console.log("ingresa a service");
    this.paramss = new HttpParams();

    this.paramss = this.paramss.set("identificacion", identificacion);
    this.paramss = this.paramss.set("currentPage", paginator.pageIndex);
    this.paramss = this.paramss.set("pageSize", paginator.pageSize);
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "PistaRestController/getPistaBySolicitante",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public getPistaByIdentificacion(sort, paginator, identificacion: string, idPistaActual: string) {
    this.paramss = new HttpParams();
    console.log("ingresa la cediula de identidad" + identificacion);
    this.paramss = this.paramss.set("identificacion", identificacion);
    this.paramss = this.paramss.set("idPistaActual", idPistaActual);
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    console.log("======>getPistaByIdentificacion paginateWrapper ", paginateWrapper);
    console.log("======>getPistaByIdentificacion options ", options);
    return this.https.post(
      this.apiUrlResourcesPista + "pistaRestController/getPistaBySolicitante", paginateWrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public setSearchParams(page: Page) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("page", "" + page.pageNumber);
    this.paramss = this.paramss.set("pageSize", "" + page.size);
    if (page.sortFields && page.sortFields !== "") {
      this.paramss = this.paramss.set("sortFields", page.sortFields);
    }
    if (page.sortDirections && page.sortDirections !== "") {
      this.paramss = this.paramss.set("sortDirections", page.sortDirections);
    }
    this.paramss = this.paramss.set("isPaginated", page.isPaginated);
  }

  guardarPista(pista: TbPiPista) {
    //  console.log( "==> nvio data a registrar pista  " + JSON.stringify( pista ) );
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = { pista };
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( wrapper ) );
    return this.https.post(this.apiUrlResourcesPista + "pistaRestController/guardarPista", pista,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  cancelarPista(id: string) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("id", id);
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.post(this.apiUrlResourcesPista + "PistaRestController/cancelPista", null,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  rechazarPista(id: string) {
    console.log("==> entidad a  service " + id);
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("id", id);
    this.paramss = this.paramss.set("user", Commons.unencript(localStorage.getItem(environment.userKey)));
    let options = { headers: this.headerss, params: this.paramss };
    let x = this.https.post(this.apiUrlResourcesPista + "pistaRestController/confirmDenyPista", null,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
    //console.log("======>>>",x);
    return x;
  }

  duplicadoPista(id: string) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("id", id);
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.post(this.apiUrlResourcesPista + "PistaRestController/pistaDuplicate", null,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  updateEstadoConcesionariaAsesor(tbPiConcesionariaAsesor) {
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiConcesionariaAsesor ) );
    return this.https.post(this.apiUrlResourcesPista + "concesionarioAsesorRestController/updateConcesionarioAsesor", tbPiConcesionariaAsesor,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findConcesionarioAsesorByParams(sort, paginator, estado) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("estado", estado);
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    // console.log("======>",paginateWrapper);
    return this.https.post(
      this.apiUrlResourcesPista + "concesionarioAsesorRestController/findConcesionarioAsesorByParams", paginateWrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findConcesionarioAsesorByConcesionarioAndSucursal(sort, paginator, codConcesionario, codSucursal) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("codConcesionario", codConcesionario);
    this.paramss = this.paramss.set("codSucursal", codSucursal);
    console.log("==>findConcesionarioAsesorByConcesionarioAndSucursal codConcesionario ",codConcesionario );
    console.log("==>findConcesionarioAsesorByConcesionarioAndSucursal codConcesionario ",codSucursal );
    console.log("==>findConcesionarioAsesorByConcesionarioAndSucursal this.paramss ",this.paramss );
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    // console.log("======>",paginateWrapper);
    return this.https.get(
      this.apiUrlResourcesPista + "concesionarioAsesorRestController/getConcesionarioAsesorByConcesionarioAndSucursal",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  guardarConcesionarioAsesor(concesionario: TbPiConcesionariaAsesor) {
    //  console.log( "==> nvio data a registrar pista  " + JSON.stringify( pista ) );
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = { concesionario };
    console.log("==> envio wrapper a registrar pista  " + JSON.stringify(concesionario));
    return this.https.post(this.apiUrlResourcesPista + "concesionarioAsesorRestController/guardarConcesionarioAsesor", concesionario,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findAsesorByParams(sort, paginator, estado) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("estado", estado);
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    console.log("======>", paginateWrapper);
    return this.https.post(
      this.apiUrlResourcesPista + "asesorComercialRestController/findAsesorByParams", paginateWrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  guardarAsesor(asesor: TbPiAsesorComercial) {
    //  console.log( "==> nvio data a registrar pista  " + JSON.stringify( pista ) );
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = { asesor };
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( asesor ) );
    return this.https.post(this.apiUrlResourcesPista + "asesorComercialRestController/guardarAsesor", asesor,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  updateEstadoAsesor(tbPiAsesor) {
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiAsesor ) );
    return this.https.post(this.apiUrlResourcesPista + "asesorComercialRestController/updateAsesor", tbPiAsesor,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  guardarSemaforizacion(semaforizacion: TbPiSemaforizacion) {
    //  console.log( "==> nvio data a registrar pista  " + JSON.stringify( pista ) );
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = { semaforizacion };
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( asesor ) );
    return this.https.post(this.apiUrlResourcesPista + "semaforizacionRestController/guardarSemaforizacion", semaforizacion,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  updateEstadoSemaforizacion(tbPiSemaforizacion) {
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiAsesor ) );
    return this.https.post(this.apiUrlResourcesPista + "semaforizacionRestController/updateSemaforizacion", tbPiSemaforizacion,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  deleteSemaforizacion(tbPiSemaforizacion) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set('id', tbPiSemaforizacion.id)
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiAsesor ) );
    return this.https.get(this.apiUrlResourcesPista + "semaforizacionRestController/deleteEntity",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findSemaforizacionByParams(sort, paginator, estado) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("estado", estado);
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    console.log("======>", paginateWrapper);
    return this.https.post(
      this.apiUrlResourcesPista + "semaforizacionRestController/findSemaforizacionByParams", paginateWrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  guardarOrdenamiento(ordenamiento: TbPiOrdenamiento) {
    //  console.log( "==> nvio data a registrar pista  " + JSON.stringify( pista ) );
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = { ordenamiento };
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( ordenamiento ) );
    return this.https.post(this.apiUrlResourcesPista + "ordenamientoRestController/guardarOrdenamiento", ordenamiento,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  updateEstadoOrdenamiento(tbPiOrdenamiento) {
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiAsesor ) );
    return this.https.post(this.apiUrlResourcesPista + "ordenamientoRestController/updateOrdenamiento", tbPiOrdenamiento,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  deleteEstadoOrdenamiento(tbPiOrdenamiento) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set('id', tbPiOrdenamiento.id);
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiAsesor ) );
    return this.https.get(this.apiUrlResourcesPista + "ordenamientoRestController/deleteEntity",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public findOrdenamientoByParams(sort, paginator, estado) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("estado", estado);
    let options = { headers: this.headerss, params: this.paramss };
    let paginateWrapper = new PaginateWrapper();
    paginateWrapper.currentPage = paginator.pageIndex;
    paginateWrapper.pageSize = paginator.pageSize;
    paginateWrapper.sort = sort;
    //console.log("======>",paginateWrapper);
    return this.https.post(
      this.apiUrlResourcesPista + "ordenamientoRestController/findOrdenamientoByParams", paginateWrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  public getDiffBetweenDateInicioActual(fechaIncio: string, formato: string) {


    this.paramss = new HttpParams();

    if (fechaIncio && fechaIncio != '') {
      this.paramss = this.paramss.set('fechaInicio', fechaIncio);
    }
    if (formato && formato != '') {
      this.paramss = this.paramss.set('formato', formato);
    }

    //console.log("==> parametros obtenidos " +  this.params.toString() );
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(
      this.apiUrlResourcesPista + "parametroRestController/getDiffBetweenDateInicioActual",
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  reasignar(data, asesorId) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idAsesor", asesorId);
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = data;
    //console.log("======>",paginateWrapper);
    return this.https.post(
      this.apiUrlResourcesPista + "pistaRestController/reasignarPistas", wrapper,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  pistaVinculada(idPistaRelacionada) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idPistaRelacionada", idPistaRelacionada);
    let options = { headers: this.headerss, params: this.paramss };

    //console.log("======>",paginateWrapper);
    return this.https.get(
      this.apiUrlResourcesPista + "vinculacionPistaRestController/pistaVinculada", options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  findObjectById(databaseName, collectionName, objectId) {
    let serviceUrl = this.apiUrlGeneric + "mongoRestController/findObjectById";
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("databaseName", databaseName);
    this.paramss = this.paramss.set("collectionName", collectionName);
    this.paramss = this.paramss.set("objectId", objectId);
    let options = { headers: this.headerss, params: this.paramss };
    return this.https.get(serviceUrl, options).pipe(
      tap( // Log the result or error
        (data: any) => data,
        error => { this.HandleError(error, this.pistaNoticeService); }
      )
    );
  }

  findArchivoByIdPista(idPista) {
    this.paramss = new HttpParams();
    this.paramss = this.paramss.set("idPista", idPista);
    let options = { headers: this.headerss, params: this.paramss };

    return this.https.get(
      this.apiUrlResourcesPista + "archivoRestController/findArchivoByIdPista", options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  sendMail(idPista,toMail, subjectMail, messageMail) {
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    let wrapper = {
      idRelacionado:idPista,
      toMail: toMail,
      subjectMail: subjectMail,
      messageMail: messageMail
    }
    console.log( "====>sendmail ",  wrapper)
    return this.https.post(
      this.apiUrlMail, wrapper, options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

  deleteAgenteConsesionario(concesionario: any) {
    this.paramss = new HttpParams();
    let options = { headers: this.headerss, params: this.paramss };
    //let wrapper = {tbPiConcesionariaAsesor};
    //console.log( "==> envio wrapper a registrar pista  " + JSON.stringify( tbPiConcesionariaAsesor ) );
    return this.https.post(this.apiUrlResourcesPista + "concesionarioAsesorRestController/delete", concesionario,
      options).pipe(
        tap( // Log the result or error
          (data: any) => data,
          error => { this.HandleError(error, this.pistaNoticeService); }
        )
      );
  }

}