import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ComponentsComponent } from './components.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CuentaComponent } from './cuenta/cuenta.component';
import { HomeComponent } from '../login/home/home.component';
import { AuthGuardService as AuthGuard } from '../core/services/generales/auth-guard.service';
import { LayoutModule } from '../layout/layout.module';
import { MenutopComponent } from '../layout/menutop/menutop.component';
import { SidebarComponent } from '../layout/sidebar/sidebar.component';
import { SidebarLoginComponent } from '../login/sidebar-login/sidebar-login.component';
import { ContentLoginComponent } from '../login/content-login/content-login.component';
import { StepsComponent } from './steps/steps.component';
import { ModalHistorialComponent } from './modal-historial/modal-historial.component';
import { LayoutComponent } from '../layout/layout.component';
import { BodyComponent } from '../layout/body/body.component';
import { TestComponent } from './test/test.component';



const routes: Routes = [
  { 
    path: '', component: ComponentsComponent,
    children: [
      {
        path: '',
        redirectTo: 'inicio',
        pathMatch: 'full'
      },
      { path: 'inicio', component: DashboardComponent,canActivate: [AuthGuard]  },
      { path: 'usuario/cuenta', component: CuentaComponent,canActivate: [AuthGuard]  },
    ]
  }
];

@NgModule({
  declarations: [
    ComponentsComponent,
    //MenutopComponent,
    //SidebarComponent,
    DashboardComponent,
    CuentaComponent,
    StepsComponent,
    ModalHistorialComponent,
    //LayoutComponent,
    //BodyComponent,
    TestComponent
  ],
  imports: [
    CommonModule,
    LayoutModule,
    RouterModule.forChild(routes)
  ]
})
export class ComponentsModule { }
