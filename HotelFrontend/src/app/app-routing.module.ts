import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ContactenosComponent } from "./pages/contactenos/contactenos.component";
import { DetallesComponent } from "./pages/habitaciones/detalles/detalles.component";
import { Detalles10Component } from "./pages/habitaciones/detalles10/detalles10.component";
import { Detalles11Component } from "./pages/habitaciones/detalles11/detalles11.component";
import { Detalles2Component } from "./pages/habitaciones/detalles2/detalles2.component";
import { Detalles3Component } from "./pages/habitaciones/detalles3/detalles3.component";
import { Detalles4Component } from "./pages/habitaciones/detalles4/detalles4.component";
import { Detalles5Component } from "./pages/habitaciones/detalles5/detalles5.component";
import { Detalles6Component } from "./pages/habitaciones/detalles6/detalles6.component";
import { Detalles7Component } from "./pages/habitaciones/detalles7/detalles7.component";
import { Detalles8Component } from "./pages/habitaciones/detalles8/detalles8.component";
import { Detalles9Component } from "./pages/habitaciones/detalles9/detalles9.component";
import { HabitacionesComponent } from "./pages/habitaciones/habitaciones.component";

import { HomeComponent } from "./pages/home/home.component";
import { ReservasComponent } from "./pages/reservas/reservas.component";
import { ServiciosComponent } from "./pages/servicios/servicios.component";

const routes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'habitaciones', component: HabitacionesComponent },
    { path: 'habitaciones/detalles', component: DetallesComponent },
    {path: 'habitaciones/detalles2',component: Detalles2Component},
    {path: 'habitaciones/detalles3',component: Detalles3Component},
    {path: 'habitaciones/detalles4',component: Detalles4Component},
    {path: 'habitaciones/detalles5',component: Detalles5Component},
    {path: 'habitaciones/detalles6',component: Detalles6Component},
    {path: 'habitaciones/detalles7',component: Detalles7Component},
    {path: 'habitaciones/detalles8',component: Detalles8Component},
    {path: 'habitaciones/detalles9',component: Detalles9Component},
    {path: 'habitaciones/detalles10',component: Detalles10Component},
    {path: 'habitaciones/detalles11',component: Detalles11Component},
    { path: 'reservas', component: ReservasComponent },
    { path: 'servicios', component: ServiciosComponent },
    { path: 'contactenos', component: ContactenosComponent },
    {path: '', redirectTo: 'home',pathMatch: 'full'}
    
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}