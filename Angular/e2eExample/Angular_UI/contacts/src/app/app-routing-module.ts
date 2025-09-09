import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewContact } from './components/new-contact/new-contact';
import { ContactList } from './components/contact-list/contact-list';
import { ErrorPage } from './components/error-page/error-page';
import { EditContact } from './components/edit-contact/edit-contact';
import { ContactView } from './components/view-contact/view-contact';

const routes: Routes = [
  {path:'',redirectTo:'contacts/viewall',pathMatch:"full"},
  {path:'contacts/viewall',component:ContactList},
  {path:'contacts/new',component:NewContact},
  {path:'contacts/edit/:id',component:EditContact},
  { path: 'contacts/view/:id', component: ContactView },
  {path:'**',component:ErrorPage}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }