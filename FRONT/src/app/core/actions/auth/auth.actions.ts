import { Action } from '@ngrx/store';
import { User } from '../../model/user';

export enum AuthActionTypes {
    LOGIN = '[Authentication] Login',
    LOGIN_SUCCESS = '[Authentication] Login Success',
    LOGIN_FAILURE = '[Authentication] Login Failure',
    LOGOUT = '[Authentication] Logout',
}

export class Login implements Action {
    readonly type = AuthActionTypes.LOGIN;
    constructor(public payload: any) {}
  }
  
  export class LoginSuccess implements Action {
    readonly type = AuthActionTypes.LOGIN_SUCCESS;
    constructor(public payload: any) {}
  }
  
  export class LoginFailure implements Action {
    readonly type = AuthActionTypes.LOGIN_FAILURE;
    constructor(public payload: any) {}
  }
  
  export class Logout implements Action {
    readonly type = AuthActionTypes.LOGOUT;
  }

export type AuthAction =
| Login
| LoginSuccess
| LoginFailure
| Logout;