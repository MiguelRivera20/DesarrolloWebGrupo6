import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { HabitacionesComponent } from './pages/habitaciones/habitaciones.component';
import { ReservasComponent } from './pages/reservas/reservas.component';
import { ServiciosComponent } from './pages/servicios/servicios.component';
import { ContactenosComponent } from './pages/contactenos/contactenos.component';
import { DetallesComponent } from './pages/habitaciones/detalles/detalles.component';
import { Detalles2Component } from './pages/habitaciones/detalles2/detalles2.component';
import { Detalles3Component } from './pages/habitaciones/detalles3/detalles3.component';
import { Detalles4Component } from './pages/habitaciones/detalles4/detalles4.component';
import { Detalles5Component } from './pages/habitaciones/detalles5/detalles5.component';
import { Detalles6Component } from './pages/habitaciones/detalles6/detalles6.component';
import { Detalles7Component } from './pages/habitaciones/detalles7/detalles7.component';
import { Detalles8Component } from './pages/habitaciones/detalles8/detalles8.component';
import { Detalles9Component } from './pages/habitaciones/detalles9/detalles9.component';
import { Detalles10Component } from './pages/habitaciones/detalles10/detalles10.component';
import { Detalles11Component } from './pages/habitaciones/detalles11/detalles11.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HabitacionesComponent,
    ReservasComponent,
    ServiciosComponent,
    ContactenosComponent,
    DetallesComponent,
    Detalles2Component,
    Detalles3Component,
    Detalles4Component,
    Detalles5Component,
    Detalles6Component,
    Detalles7Component,
    Detalles8Component,
    Detalles9Component,
    Detalles10Component,
    Detalles11Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
