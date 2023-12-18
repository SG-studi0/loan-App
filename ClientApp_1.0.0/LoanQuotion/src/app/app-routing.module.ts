import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerComponent } from './customer/customer.component';
import { QuotionComponent } from './quotion/quotion.component';

const routes: Routes = [
  { path: '', redirectTo: 'app-customer', pathMatch: 'full' },
  { path: 'app-customer', component: CustomerComponent },
   {path :'app-quotion', component: QuotionComponent} 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
