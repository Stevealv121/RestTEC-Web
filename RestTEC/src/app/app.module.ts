import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AdministrationComponent } from './administration/administration.component';
import { ChefComponent } from './chef/chef.component';
import { LoginAdminComponent } from './login-admin/login-admin.component';
import { DishesComponent } from './dishes/dishes.component';
import { MenuComponent } from './menu/menu.component';
import { ReportsComponent } from './reports/reports.component';
import { LoginChefComponent } from './login-chef/login-chef.component';
import { AssignOrdersComponent } from './assign-orders/assign-orders.component';
import { OrdersControlComponent } from './orders-control/orders-control.component';
import { SignUpComponent } from './sign-up/sign-up.component';

import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule }  from '@angular/forms';
import { EditMenuComponent } from './edit-menu/edit-menu.component';
import { NewDishComponent } from './new-dish/new-dish.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AdministrationComponent,
    ChefComponent,
    LoginAdminComponent,
    DishesComponent,
    MenuComponent,
    ReportsComponent,
    LoginChefComponent,
    AssignOrdersComponent,
    OrdersControlComponent,
    SignUpComponent,
    EditMenuComponent,
    NewDishComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
