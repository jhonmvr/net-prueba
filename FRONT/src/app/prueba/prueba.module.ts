import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { LayoutModule } from '../layout/layout.module';
import { ComponentsModule } from '../components/components.module';
import { MatInputModule } from '@angular/material/input';
import { MultiSelectAllModule } from '@syncfusion/ej2-angular-dropdowns';
import { CheckBoxModule, ButtonModule } from '@syncfusion/ej2-angular-buttons';
import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
// Material
import {
	MatPaginatorModule,
	MatProgressSpinnerModule,
	MatSortModule,
	MatTableModule,
	MatSelectModule,
	MatMenuModule,
	MatProgressBarModule,
	MatButtonModule,
	MatCheckboxModule,
	MatDialogModule,
	MatTabsModule,
	MatNativeDateModule,
	MatCardModule,
	MatRadioModule,
	MatIconModule,
	MatDatepickerModule,
	MatExpansionModule,
	MatAutocompleteModule,
	MatSnackBarModule,
	MatTooltipModule,
	MatBadgeModule,
	MatBottomSheetModule,
	MatButtonToggleModule,
	MatChipsModule,
	MatStepperModule,
	MatDividerModule,
	MatGridListModule,
	MatListModule,
	MatRippleModule,
	MatSidenavModule,
	MatSliderModule,
	MatSlideToggleModule,
	MatToolbarModule,
	MatTreeModule,
	MatFormFieldModule,
} from '@angular/material';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { A11yModule } from '@angular/cdk/a11y';
import { CdkStepperModule } from '@angular/cdk/stepper';
import { CdkTableModule } from '@angular/cdk/table';
import { CdkTreeModule } from '@angular/cdk/tree';
import { PortalModule } from '@angular/cdk/portal';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { ListPersonaComponent } from './list-persona/list-persona.component';
import { CrearPersonaComponent } from './list-persona/crear-persona/crear-persona.component'

import { AuthGuardService as AuthGuard } from '../core/services/generales/auth-guard.service';
import { PruebaComponent } from './prueba.component';


const routes: Routes = [
	{
		path: '', component: PruebaComponent,
		children: [
			{
				path: '',
				redirectTo: '',
				pathMatch: 'full'
			},
			{
				path: 'list-persona',
				component: ListPersonaComponent
			},
			{
				path: 'new-persona',
				component: CrearPersonaComponent
			},
		]
	}
];

@NgModule({
  declarations: [
	PruebaComponent,
	ListPersonaComponent,
	CrearPersonaComponent
    //MenutopComponent,
    //SidebarComponent,
    //CuentaComponent,
    //StepsComponent,
    //ModalHistorialComponent,
    //LayoutComponent,
    //BodyComponent,
    //TestComponent
  ],
  imports: [
		A11yModule,
		CdkStepperModule,
		CdkTableModule,
		CdkTreeModule,
		MatBadgeModule,
		MatBottomSheetModule,
		MatButtonToggleModule,
		MatChipsModule,
		MatStepperModule,
		MatDividerModule,
		MatExpansionModule,
		MatGridListModule,
		MatListModule,
		MatRippleModule,
		MatSidenavModule,
		MatSliderModule,
		MatSlideToggleModule,
		MatToolbarModule,
		MatTreeModule,
		PortalModule,
		ScrollingModule,
		NgMultiSelectDropDownModule.forRoot(),

	CommonModule,
	FormsModule,
	ReactiveFormsModule,
    LayoutModule,
    ComponentsModule,
    MatButtonModule,
	MatMenuModule,
	MatSelectModule,
    MatInputModule,
	MatTableModule,
	MatAutocompleteModule,
	MatRadioModule,
	MatIconModule,
	MatNativeDateModule,
	MatProgressBarModule,
	MatDatepickerModule,
	MatCardModule,
	MatPaginatorModule,
	MatSortModule,
	MatCheckboxModule,
	MatProgressSpinnerModule,
	MatSnackBarModule,
	MatExpansionModule,
	MatTabsModule,
	MatTooltipModule,
	MatDialogModule,
	MatInputModule,
	MatFormFieldModule,
	MultiSelectAllModule, 
	ButtonModule, 
	CheckBoxModule,
    RouterModule.forChild(routes)
  ],
  entryComponents:[
	  
  ]
})
export class PruebaModule { }
