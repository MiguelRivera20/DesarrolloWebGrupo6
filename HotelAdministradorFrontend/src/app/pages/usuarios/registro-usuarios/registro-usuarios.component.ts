import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { JsMaestra } from 'src/app/clases/JsMaestra';
import { MaestraService } from 'src/app/services/maestra.service';

@Component({
  selector: 'app-registro-usuarios',
  templateUrl: './registro-usuarios.component.html',
  styleUrls: ['./registro-usuarios.component.css']
})
export class RegistroUsuariosComponent implements OnInit {

  lstTipoDocumento : JsMaestra[] = [];
  RegistroUsuarioForm = this.fb.group({
    co_Usuario: [0],
    co_Persona: this.fb.group({
      firstname: ['', Validators.required],
      lastname: ['', Validators.required]
    }),
    co_Perfil: [0,Validators.required],
    email: ['', [Validators.required, Validators.email]],
    message: ['']
  });


  constructor(
    private readonly ms : MaestraService,
    private ar: ActivatedRoute,
    private fb: FormBuilder
  ) { }

  __getMaestraTipoDocumento(maestra: string) {
    const param = maestra;

    this.ms.__getMaestra(param).subscribe((rest: any) => {
     // this.lstTipoDocumento =  rest.data;
      var data1 = new JsMaestra();
     // this.lstTipoDocumento = [];
      //this.lstTipoDocumento.push(data1);
      var resultArray = Object.keys(rest.data).map(function(personNamedIndex){
        let person = rest.data[personNamedIndex];
        // do something with person
        return person;
    });
    this.lstTipoDocumento = resultArray;
      console.log(this.lstTipoDocumento);
    })
  }

  ngOnInit(): void {
    //Maestra
    this.__getMaestraTipoDocumento('TIPO_DOCUMENTO');
  }

}
