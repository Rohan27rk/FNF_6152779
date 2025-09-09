import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Calc } from './Components/calc/calc';
import { Master } from './Components/master/master';
import { Emp } from './Components/emp/emp';
import { App } from './app';
import { ValidationForm } from './validation-form/validation-form';
import { FormsModule } from '@angular/forms';
import { EmpDetails } from './Components/emp-details/emp-details';
import { ReactiveForm } from './Components/reactive-form/reactive-form';

const routes: Routes = [
  {path: "", redirectTo: "", pathMatch:'full'},
  // {path: "Home", component: App},
  {path: "Calc", component: Calc},
  {path: "Master-Details", component: Master},
  // {path: "Employee", component: Emp},
  {path: "Validation-Form", component:ValidationForm },
  // {path:"FormsModule", component: FormsModule},
  {path:"emp", component: Emp},
  {path:"reactive-form", component:ReactiveForm},
  { path: 'admin', loadChildren: () => import('./Modules/admin/admin-module').then(m => m.AdminModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
