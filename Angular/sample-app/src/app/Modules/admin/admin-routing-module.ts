import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Admin } from './admin';
import { Dashboard } from '../../Components/dashboard/dashboard';
import { User } from '../../Components/user/user';
import { Rights } from '../../Components/rights/rights';

const routes: Routes = [{ path: 'Admin',
  children:[
    {path:"dashboard", component:Dashboard},
    {path:"user", component:User},
    {path:"rights", component:Rights}
  ]
 }];

@NgModule({
  imports: [RouterModule.forChild(routes)],//this module shall load the components on request only
  exports: [RouterModule]
})
export class AdminRoutingModule { }
