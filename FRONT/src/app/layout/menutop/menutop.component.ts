import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../core/services/generales/authentication.service';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Logout } from 'src/app/core/actions';
import { selectAuthenticationState } from 'src/app/core/states/auth.states';
import { Commons } from 'src/app/core/util/common';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-menutop',
  templateUrl: './menutop.component.html',
  styleUrls: ['./menutop.component.css']
})
export class MenutopComponent implements OnInit {

  getState:Observable<any>;
  email:string="";
  iconoUrl="";

  constructor( private auth: AuthenticationService, private router: Router, private store:Store ) {
    this.iconoUrl=environment.rootContext;
    this.getState = this.store.select(selectAuthenticationState);
   }

  ngOnInit() {
    this.email=Commons.unencript( localStorage.getItem(environment.emailKey ) );
    this.getState.subscribe((state) => {
      //console.log( "llllllll=> logaout: " + JSON.stringify( state ) )
    });
  }

  salir(){
   
    this.store.dispatch(new Logout());
    //this.auth.logout();
    //this.router.navigateByUrl('/login');
  }

}
