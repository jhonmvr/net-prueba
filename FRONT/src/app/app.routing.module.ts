import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './login/home/home.component';

const routes: Routes = [
  {path: '', loadChildren: () => import('./prueba/prueba.module').then(m => m.PruebaModule) },
  { path: 'login', component: HomeComponent },
  { path: 'prueba', loadChildren: () => import('./prueba/prueba.module').then(m => m.PruebaModule) },
  { path: 'layout', loadChildren: () => import('./layout/layout.module').then(m => m.LayoutModule) },
  { path: 'components', loadChildren: () => import('./components/components.module').then(m => m.ComponentsModule) }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }