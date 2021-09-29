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
import { TipoHabitacionComponent } from "./pages/tipo-habitacion/tipo-habitacion.component";
import { RegistroTipoHabitacionComponent } from "./pages/tipo-habitacion/registro-tipo-habitacion/registro-tipo-habitacion.component";
import { HabitacionesComponent } from "./pages/habitaciones/habitaciones.component";
import { RegistroHabitacionComponent } from "./pages/habitaciones/registro-habitacion/registro-habitacion.component";


const routes: Routes = [
    { path: 'inicio', component: InicioComponent },
    { path: 'usuarios', component: UsuariosComponent },
    { path: 'usuarios/registro-usuario', component: RegistroUsuariosComponent },
    { path: 'usuarios/registro-usuario/:tipoDoc/:numDoc', component: RegistroUsuariosComponent },
    { path: 'Habitaciones/detalle-habitacion', component: RegistroDetalleHabitacionComponent },
    { path:"Control_Habitaciones/Reserva", component: ReservaComponent},
    { path:'Control_Habitaciones/Check_in', component:CheckinComponent},
    {path: 'Control_Habitaciones/Reserva/Registro_Reserva', component:RegistroReservaComponent},
    {path:'Control_Habitaciones/Check_in/registro_checkin', component:RegistroCheckinComponent},
    {path:'Control_Habitaciones/tipo-habitacion', component: TipoHabitacionComponent},
    {path:'habitaciones/habitacion', component: HabitacionesComponent},
    {path:'habitaciones/habitacion/registro', component: RegistroHabitacionComponent},
    {path:'Control_Habitaciones/tipo-habitacion/registro-tipo-habitacion', component: RegistroTipoHabitacionComponent}
    
    
];


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}