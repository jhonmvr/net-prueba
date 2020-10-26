import { User } from '../../model/user';
import {  AuthActionTypes, AuthAction } from '../../actions';

export interface State {
  isAuthenticated: boolean;
  user: User | null;
  errorMessage: string | null;
}

export interface AppState {
  authState:State;
}

//set the initial state with localStorage
export const initialState: State = {
  isAuthenticated: false,
  user: {
          token: "",//localStorage.getItem(environment.tokenKey),
          email: "",//localStorage.getItem(environment.userKey),
          id:"",
          user:"",
          nombre:"",
          password:"",
          rol:"",//localStorage.getItem(environment.rolKey)
          sucursal:""
        },
  errorMessage: null
};



export function reducer(state = initialState, action: AuthAction): State {
  //console.log("===> entra a reducer " + JSON.stringify( action ));
  switch (action.type) {
    case AuthActionTypes.LOGIN: {
      //console.log("bbbbbbbbbbbb===> entra a reducer LOGIN " + JSON.stringify( action ) );
      return {
        ...state,
        isAuthenticated: false,
        user: {
          token: action.payload.token,
          email: action.payload.email,
          id: action.payload.user, //id:"",
          user: action.payload.user, //id:"",
          nombre:"",
          password:"",
          rol:action.payload.rol,
          sucursal:action.payload.sucursal
        },
        errorMessage: null
      };
    }
    case AuthActionTypes.LOGIN_SUCCESS: {
      //console.log("kkkkkkkkkkk===> entra a reducer LOGIN_SUCCESS " + JSON.stringify( action ) );
      return {
        ...state,
        isAuthenticated: true,
        user: {
          token: action.payload.token,
          email: action.payload.email,
          id: action.payload.user, //id:"",
          user: action.payload.user, //id:"",
          nombre:"",
          password:"",
          rol:action.payload.rol,
          sucursal:action.payload.sucursal
        },
        errorMessage: null
      };
    }
    case AuthActionTypes.LOGIN_FAILURE: {
      //console.log("kkkkkkkkkkk===> entra a reducer LOGIN_FAILURE" );
      return {
        ...state,
        isAuthenticated: false,
        errorMessage: action.payload.error//'Wrong credentials.'
      };
    }
    
    case AuthActionTypes.LOGOUT: {
      return initialState;
    }
    default: {
      return state;
    }
  }
}