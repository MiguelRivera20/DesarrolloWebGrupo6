import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ContactenosComponent } from "./pages/contactenos/contactenos.component";
import { DetallesComponent } from "./pages/habitaciones/detalles/detalles.component";
import { HabitacionesComponent } from "./pages/habitaciones/habitaciones.component";

import { HomeComponent } from "./pages/home/home.component";
import { ReservasComponent } from "./pages/reservas/reservas.component";
import { ServiciosComponent } from "./pages/servicios/servicios.component";

const routes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'habitaciones', component: HabitacionesComponent },
    { path: 'habitaciones/detalles', component: DetallesComponent },
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