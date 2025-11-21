import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Home } from './home/home';
import { Customers } from './customers/customers';
import { Transactions } from './transactions/transactions';

const routes: Routes = [
  { path: '', component: Home, pathMatch: 'full' },
  { path: 'customers', component: Customers },
  { path: 'transaction', component: Transactions },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
