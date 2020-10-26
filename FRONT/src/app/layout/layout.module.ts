import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule, Router } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { BodyComponent } from './body/body.component';
import { MenutopComponent } from './menutop/menutop.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { ReMessageComponent } from './re-message/re-message.component';
import { MatSnackBarModule, MatButtonModule, MatCardModule ,MatToolbarModule,MatIconModule, MatSelectModule  } from '@angular/material';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatMenuModule} from '@angular/material/menu';



/**const routes: Routes = [
  { path: '', component: LayoutComponent }
];*/

@NgModule({
  declarations: [
    LayoutComponent,
    BodyComponent,
    MenutopComponent,
    SidebarComponent,
    ReMessageComponent,
   
  ],
  imports: [
    CommonModule,
    MatSnackBarModule,
    RouterModule,
    MatSidenavModule,
    MatMenuModule,
    MatButtonModule,
    MatCardModule,
    MatToolbarModule,
    MatIconModule,
    MatSelectModule
    //RouterModule.forChild(routes)
  ],
  exports:[
    LayoutComponent,
    BodyComponent,
    MenutopComponent,
    SidebarComponent,
    ReMessageComponent
  ]
})
export class LayoutModule { }
