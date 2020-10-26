import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { AuthenticationService } from './authentication.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService implements CanActivate {
  constructor( public router: Router, private authService:AuthenticationService) {}
  
  canActivate(): boolean {
    if (!this.isAuthenticatedRelative()) {
      this.router.navigate(['login']);
      return false;
    }
    return true;
  }

  private isAuthenticatedRelative(){
    if( this.authService.isLoggedIn() ){
      return true;
    } else {
      return false;
    }
  }
}


