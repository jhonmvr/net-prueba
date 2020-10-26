import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { HomeComponent } from './login/home/home.component';


import { AuthGuardService as AuthGuard } from './core/services/generales/auth-guard.service';
import { ContentLoginComponent } from './login/content-login/content-login.component';
import { SidebarLoginComponent } from './login/sidebar-login/sidebar-login.component';
import { ComponentsModule } from './components/components.module';
import { LayoutModule } from './layout/layout.module';
import { LayoutComponent } from './layout/layout.component';
import { ComponentsComponent } from './components/components.component';

import { EffectsModule } from '@ngrx/effects';
import { StoreModule } from '@ngrx/store';
import { AuthenticationEffects } from './core/effects/auth/auth.effects';
import { reducers } from './core/states/auth.states';
import { ReMessageComponent } from './layout/re-message/re-message.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { AppRoutingModule } from './app.routing.module';
import { LoaderComponent } from './core/loader/loader.component';
import { LoaderInterceptor } from './core/interceptors/loader.interceptor';
import { MatProgressSpinnerModule } from '@angular/material';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SidebarLoginComponent,
    ContentLoginComponent,
    LoaderComponent

  ],
  imports: [
    NgbModule,
    MatProgressSpinnerModule,
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ComponentsModule,
    LayoutModule,
    AppRoutingModule,
    //environment.isMockEnabled ? HttpClientInMemoryWebApiModule.forRoot(FakeApiService) : [],
    HttpClientModule,
    //RouterModule.forRoot(routes),
    EffectsModule.forRoot([AuthenticationEffects]),
    StoreModule.forRoot(reducers, {})
  ],
  exports: [ 
   
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: LoaderInterceptor, multi: true },
    AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
