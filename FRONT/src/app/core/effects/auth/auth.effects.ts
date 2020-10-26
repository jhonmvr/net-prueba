//authentication.effects.ts
import { Injectable } from '@angular/core';
import { Action } from '@ngrx/store';
import { Router } from '@angular/router';
import { Actions, Effect, ofType } from '@ngrx/effects';
import { Observable, of } from 'rxjs';
import { map, switchMap, catchError, tap } from 'rxjs/operators';

import { AuthenticationService } from '../../services/generales/authentication.service';
import {
  AuthActionTypes,
  Login, LoginSuccess, LoginFailure,Logout
} from '../../actions';
import { environment } from 'src/environments/environment';
import { Commons } from '../../util/common';


@Injectable()
export class AuthenticationEffects {

  constructor(
    private actions: Actions,
    private authenticationService: AuthenticationService,
    private router: Router,
  ) {}

  @Effect()
  Login: Observable<any> = this.actions.pipe(
      ofType(AuthActionTypes.LOGIN),  
      map((action: Login) => action.payload),
      switchMap((payload:any) => {
        return this.authenticationService.login(payload.user, payload.password)
        .pipe(
          map((user) => {
            //console.log("!!!!!!!!!!!===> Login auth effects " + JSON.stringify(user)  );
            //return new LoginSuccess({token: user.token, user:payload.user, email: payload.email,rol:user.rol});
            return new LoginSuccess(user);
          }),
          catchError((error) => {
            return of(new LoginFailure({ error: error }));
          }));
  }));


  @Effect({ dispatch: false })
  LoginSuccess: Observable<any> = this.actions.pipe(
    ofType(AuthActionTypes.LOGIN_SUCCESS),
    tap((user) => {
      let c:Commons= new Commons();
      //console.log("!!!!!!!!!!!!!!!!===> LoginSuccess auth effects " + JSON.stringify(user)  );
      //when the user logs in successfully, the token and email are saved to localStorage
      localStorage.setItem(environment.tokenKey,  Commons.encript(user.payload.token));
      localStorage.setItem(environment.userKey,  Commons.encript(user.payload.user));
      localStorage.setItem(environment.emailKey,  Commons.encript(user.payload.email));
      localStorage.setItem(environment.rolKey,  Commons.encript(user.payload.rol));
      this.router.navigateByUrl('/');
    })
  );

  @Effect({ dispatch: false })
  LoginFailure: Observable<any> = this.actions.pipe(
    ofType(AuthActionTypes.LOGIN_FAILURE)
  );

  @Effect({ dispatch: false })
  public Logout: Observable<any> = this.actions.pipe(
    ofType(AuthActionTypes.LOGOUT),
    tap((user) => {
      //when the user log out the token and email are removed from localStorage
      localStorage.removeItem(environment.tokenKey);
      localStorage.removeItem(environment.userKey);
      localStorage.removeItem(environment.rolKey);
      localStorage.removeItem(environment.emailKey);
      this.router.navigateByUrl('/login');
    })
  );
}