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
  //  lstTipoDocumento : JsMaestra[] = [];
  listaUsuario: JsUsuarioPersona[] = [];
  constructor(
    private ar: ActivatedRoute,
    private fb: FormBuilder,
    private readonly us : UsuarioService
  ) { }

  __ListarUsuariosPorFiltro() {
   

    this.us.__listarUsuariosPorfiltro(1,'').subscribe((rest: any) => {
      this.listaUsuario = rest.data;
      console.log(this.listaUsuario);
     // this.lstTipoDocumento =  rest.data;
        });
    }

  ngOnInit(): void {
    this.__ListarUsuariosPorFiltro();
  }

}
