import { createFeatureSelector } from '@ngrx/store';
import * as authentication from '../reducers/auth/auth.reducer';


export interface AppState {
  authenticationState: authentication.State;
}

export const reducers = {
  authentication: authentication.reducer
};

export const selectAuthenticationState = createFeatureSelector<AppState>('authentication');