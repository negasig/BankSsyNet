import { HttpClientModule } from '@angular/common/http';
import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Home } from './home/home';
import { Customers } from './customers/customers';
import { Transactions } from './transactions/transactions';
import { About } from './about/about';
import { NavMenu } from './nav-menu/nav-menu';
import { RouterLink } from '@angular/router';

@NgModule({
  declarations: [
    App,
    Home,
    Customers,
    Transactions,
    About,
    NavMenu
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, RouterLink
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }
