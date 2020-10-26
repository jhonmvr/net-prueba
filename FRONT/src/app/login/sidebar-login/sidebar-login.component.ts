import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '../../core/actions';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { select, Store } from '@ngrx/store';
import { User } from '../../core/model/user';
import { selectAuthenticationState } from '../../core/states/auth.states';
import { Observable } from 'rxjs';
import { stringify } from 'querystring';
import { ReNoticeService } from 'src/app/core/services/generales/re-notice.service';
import { BindingFlags } from '@angular/compiler/src/core';
import {environment} from "../../../environments/environment"

@Component({
  selector: 'app-sidebar-login',
  templateUrl: './sidebar-login.component.html',
  styleUrls: ['./sidebar-login.component.css']
})
export class SidebarLoginComponent implements OnInit {

  
  iconoUrl="";
  mensajeError:string="";
  getState: Observable<any>;
  errorMessage: string = null;
  formLogin = new FormGroup({
    usuario: new FormControl('', [Validators.required, Validators.minLength(2),Validators.maxLength(150)]),
    password: new FormControl('', [Validators.required,Validators.minLength(3),Validators.maxLength(20)]),
  });

  constructor(private store:Store, private router:Router, private ns:ReNoticeService ) {
    this.iconoUrl=environment.rootContext;
    this.getState = this.store.select(selectAuthenticationState);
    
   }

  ngOnInit() {
    this.getState.subscribe((state) => {
      //console.log( "=> estado observador: " + JSON.stringify( state ) )
      this.errorMessage = state.errorMessage;
      if( state.isAuthenticated==false && state.errorMessage){
        this.ns.setNotice("ERROR EN LOGIN, INGRESE EL USUARIO Y PASSWORD CORRECTO", "error");
      } else {
        this.ns.setNotice(null);
      }
    });
  }

  login(){
    console.log("hizo login");
    localStorage.setItem( "token","luis" );
    this.router.navigate(['/components/inicio']);
  }

  onLogin() {
    //console.log("valid form login " +this.formLogin.valid );
   
    if( this.formLogin.valid ){
      /*const actionPayload = {
        user: this.formLogin.get("usuario").value,
        password: this.formLogin.get("password").value
      };
      console.log("Objecto login " + JSON.stringify( actionPayload ) );
      */
      const actionPayload:User=new User();
      actionPayload.user=this.formLogin.get("usuario").value;
      actionPayload.password=this.formLogin.get("password").value;
      this.store.dispatch(new Login(actionPayload));
    } else  {
      this.ns.setNotice("ERROR EN LOGIN, INGRESE EL USUARIO Y PASSWORD", "error");
    }

     
  }

  //usuario: new FormControl('', [Validators.required, Validators.minLength(2),Validators.maxLength(150)]),
  //password: new FormControl('', [Validators.required,Validators.minLength(3),Validators.maxLength(20)]),

  hasError(nombreCampo:string):boolean{
    let flag=false;
    if( this.formLogin.dirty || this.formLogin.touched ){
      if( this.formLogin.get(nombreCampo).hasError('required')  ){
        this.errorMessage="El campo es requerido " + nombreCampo;
        if( nombreCampo === "usuario" ){
          this.errorMessage="El campo es requerido usuario " ;
        } else {
          this.errorMessage="El campo es requerido password" ;
        }
        flag=true;
      }
      if( this.formLogin.get(nombreCampo).hasError('minLength') || this.formLogin.get(nombreCampo).hasError('maxLength')  ){
        if( nombreCampo === "usuario" ){
          this.errorMessage="El campo usuario debe tener minimo 2 y maximo 150";
        } else {
          this.errorMessage="El campo usuario debe tener minimo 4 y maximo 20";
        }
        flag=true;
      }
      return flag;
    } else {
      return false;
    } 
  }
  
}
