import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { JsUsuarioPersona } from 'src/app/clases/JsUsuarioPersona';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {
  prmFiltroUsuario= {
    co_Perfil:0,
    tx_Username:''
  };
  prmUsuarioFiltro = new  JsUsuarioPersona();
  //  lstTipoDocumento : JsMaestra[] = [];
  prmUsuarioEliminar = new JsUsuarioPersona();
  listaUsuario: JsUsuarioPersona[] = [];
  constructor(
    private ar: ActivatedRoute,
    private fb: FormBuilder,
    private readonly us : UsuarioService
  ) { }

  __ListarUsuariosPorFiltro() {
   
console.log(this.prmUsuarioFiltro.co_Perfil);
console.log(this.prmUsuarioFiltro.tx_Username);
    this.us.__listarUsuariosPorfiltro(this.prmUsuarioFiltro.co_Perfil,this.prmUsuarioFiltro.tx_Username).subscribe((rest: any) => {
      this.listaUsuario = rest.data;
      console.log(this.listaUsuario);
     // this.lstTipoDocumento =  rest.data;
        });
    }
    __eliminarUsuario(prmData: any){
      this.prmUsuarioEliminar = prmData;
    }

  ngOnInit(): void {
    this.__ListarUsuariosPorFiltro();
  }

}
