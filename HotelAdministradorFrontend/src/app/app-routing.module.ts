import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";


import { InicioComponent } from "./pages/inicio/inicio.component";
import { RegistroDetalleHabitacionComponent } from "./pages/registro-detalle-habitacion/registro-detalle-habitacion.component";
import { ReservaComponent } from "./pages/reserva/reserva.component";
import { RegistroUsuariosComponent } from "./pages/usuarios/registro-usuarios/registro-usuarios.component";
import { UsuariosComponent } from "./pages/usuarios/usuarios.component";
import { CheckinComponent } from "./pages/checkin/checkin.component";
import { RegistroReservaComponent } from "./pages/reserva/registro-reserva/registro-reserva.component";
import { RegistroCheckinComponent } from "./pages/checkin/registro-checkin/registro-checkin.component";


const routes: Routes = [
    { path: 'inicio', component: InicioComponent },
    { path: 'usuarios', component: UsuariosComponent },
    { path: 'usuarios/registro-usuario', component: RegistroUsuariosComponent },
    { path: 'Habitaciones/detalle-habitacion', component: RegistroDetalleHabitacionComponent },
    { path:"Control_Habitaciones/Reserva", component: ReservaComponent},
    { path:'Control_Habitaciones/Check_in', component:CheckinComponent},
    {path: 'Control_Habitaciones/Reserva/Registro_Reserva', component:RegistroReservaComponent},
    {path:'Control_Habitaciones/Check_in/registro_checkin', component:RegistroCheckinComponent}
    
    
];


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}