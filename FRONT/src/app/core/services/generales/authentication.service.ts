import { Injectable } from '@angular/core';
import { User } from '../../model/user';
import { Observable } from 'rxjs';
import { Logout } from '../../actions/auth/auth.actions';
import { LongingService } from './loging.service';
import { environment } from 'src/environments/environment';
import * as uuid from 'uuid';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  testUserS: User = {id:"",nombre:"",email: 'supervisor',password: '1234', token: 'xxxxxx',rol:"SUPERVISOR",user:"",sucursal:""};
  testUserA: User = {id:"",nombre:"",email: 'admin',password: '1234', token: 'xxxxxx',rol:"ASESOR",user:"",sucursal:""};
  constructor(private logSeervice:LongingService) {
    logSeervice.setParameter();
   }

  getToken(): string {
    return localStorage.getItem(environment.tokenKey);
  }

  isLoggedIn() {
    const token = this.getToken();
    return token != null;
  }
//con ws
  /* login(email: string, password: string): Observable<any> {
    //console.log("entra a loging",email," ",password) 
    return new Observable((observer) => {
      this.logSeervice.logingWS(email,password).subscribe(p=>{
        //console.log("termina  loging",p)
        if(p.error){
          observer.error({error: 'Error en autenticacion. ' + p.error + " " + p.resultado });
        } else {
          //localStorage.setItem( environment.userdata, btoa( JSON.stringify( p ) ) );
          const u:User= new User();
          u.user=p.username;
          u.email=p.email;
          u.id=p.user;
          u.rol=p.roles[0];
          u.sucursal=p.sucursal[0];
          u.token=uuid.v4();
          //console.log("===> se loego correcto con user " + JSON.stringify( u ));
          //observer.next({email: p.email, token:btoa(p.email), user:p.username, rol:p.roles[0] });
          observer.next(u);
        } 
        observer.complete();
      }, error=>{
        if( error && error.error ){
          observer.error({error: 'Error en autenticacion. ' + error.error});
        }
        observer.complete();
      })
     
    });
    //this would probably make an http post to the server to process the login
    //return this.http.post<User>(url, {email, password});
  } */


  //sin ws
  login(email: string, password: string): Observable<any> {
    console.log("entra a loging",email," ",password)
   
    return new Observable((observer) => {
      if (email === this.testUserA.email && password === this.testUserA.password) {
        const u:User= new User();
        u.user="asesor";
        u.email="asesor@mfc.com";
        u.id="asesor";
        u.rol="ASESOR";
        u.sucursal="001";
        u.token=uuid.v4();
        //observer.next({email: this.testUserA.email, token: this.testUserA.token,rol:this.testUserA.rol});
        observer.next(u);
      } else if (email === this.testUserS.email && password === this.testUserS.password) {
        //observer.next({email: this.testUserS.email, token: this.testUserS.token,rol:this.testUserS.rol});
        const u:User= new User();
        u.user="supervisor";
        u.email="supervisor@mfc.com";
        u.id="supervisor";
        u.rol="SUPERVISOR";
        u.sucursal="001";
        u.token=uuid.v4();
        observer.next(u);
      } else{
        observer.error({error: 'invalid credentials.'});
      }
      observer.complete();
     
    });
    //this would probably make an http post to the server to process the login
    //return this.http.post<User>(url, {email, password});
  }

  logout(){
    localStorage.removeItem(environment.tokenKey);
    localStorage.removeItem(environment.rolKey);
    localStorage.removeItem(environment.userKey);
    localStorage.removeItem(environment.userKey);
  }
}
