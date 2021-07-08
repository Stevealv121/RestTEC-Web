import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdministrationComponent } from './administration/administration.component';
import { AssignOrdersComponent } from './assign-orders/assign-orders.component';
import { ChefComponent } from './chef/chef.component';
import { DishesComponent } from './dishes/dishes.component';
import { HomeComponent } from './home/home.component';
import { LoginAdminComponent } from './login-admin/login-admin.component';
import { LoginChefComponent } from './login-chef/login-chef.component';
import { MenuComponent } from './menu/menu.component';
import { OrdersControlComponent } from './orders-control/orders-control.component';
import { ReportsComponent } from './reports/reports.component';

const routes: Routes = [
  {path: "", pathMatch: "full",redirectTo: "/home"},
  {path: "home", component: HomeComponent},
  {path: "administration", component: AdministrationComponent},
  {path: "assign-orders", component: AssignOrdersComponent},
  {path: "chef", component: ChefComponent},
  {path: "dishes", component: DishesComponent},
  {path: "login-admin", component: LoginAdminComponent},
  {path: "login-chef", component: LoginChefComponent},
  {path: "menu", component: MenuComponent},
  {path: "orders-control", component: OrdersControlComponent},
  {path: "reports", component: ReportsComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
