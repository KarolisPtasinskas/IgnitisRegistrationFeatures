import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { FormListComponent } from './Components/form-list/form-list.component';
import { EditFormComponent } from './Components/edit-form/edit-form.component';
import { RegFormComponent } from './Components/reg-form/reg-form.component';

const appRoutes: Routes = [
  { path: '', component: FormListComponent },
  { path: 'edit-form/:id', component: EditFormComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    FormListComponent,
    EditFormComponent,
    RegFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
