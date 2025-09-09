import { NgModule, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { NewContact } from './components/new-contact/new-contact';
import { ContactView } from './components/view-contact/view-contact';
import { EditContact } from './components/edit-contact/edit-contact';
import { ContactList } from './components/contact-list/contact-list';
import { ErrorPage } from './components/error-page/error-page';
import { Navbar } from './components/navbar/navbar';
import { provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    App,
    ContactView,
    ContactList,
    EditContact,
    NewContact,
    ErrorPage,
    Navbar
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection(),
    provideHttpClient()
  ],
  bootstrap: [App]
})
export class AppModule { }
