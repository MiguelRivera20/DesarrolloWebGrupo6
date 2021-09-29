import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Params } from '@angular/router';
import { JsMaestra } from 'src/app/clases/JsMaestra';
import { MaestraService } from 'src/app/services/maestra.service';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-registro-usuarios',
  templateUrl: './registro-usuarios.component.html',
  styleUrls: ['./registro-usuarios.component.css']
})
export class RegistroUsuariosComponent implements OnInit {

  lstTipoDocumento : JsMaestra[] = [];
  registroUsuarioForm = this.fb.group({
    co_Usuario: [0],
    co_Persona: [0],
    persona: this.fb.group({
      
      co_Tipo_Doc: [0, Validators.required],
      tx_Numero_Documento: ['', Validators.required],
      tx_Nombre_Completo: ['', Validators.required],
      tx_Correo: ['', Validators.required],
      tx_Telefono: [''],
      tx_Direccion: [''],
     // fe_Naciemiento: [''],
      co_Genero: [0, Validators.pattern("^[0-9]*$")]
      
    }),
    co_Perfil: [0,Validators.required],
    tx_Username: ['',Validators.required],
    co_Situacion: ['',Validators.required]
  //  email: ['', [Validators.required, Validators.email]],
   // message: ['']
  });


  constructor(
    private readonly ms : MaestraService,
    private readonly us : UsuarioService,
    private ar: ActivatedRoute,
    private fb: FormBuilder
  ) { }
  
  __poblarInfoRegistroUsuario(
      co_Tipo_Doc: number
    , tx_Numero_Documento: string
    , tx_Nombre_Completo: string
    , tx_Correo: string
    , tx_Telefono: string
    , tx_Direccion: string
    , co_Genero: number

    , co_Usuario: number
    , co_Persona: number
    , co_Perfil: number
    , tx_Username: string
    , co_Situacion: number
    , fe_fecha_nacimiento: string
    ){
     this.registroUsuarioForm = this.fb.group({
    co_Usuario: [co_Usuario],
    co_Persona: [co_Persona],
    persona: this.fb.group({
      
      co_Tipo_Doc: [co_Tipo_Doc, Validators.required],
      tx_Numero_Documento: [tx_Numero_Documento, Validators.required],
      tx_Nombre_Completo: [tx_Nombre_Completo, Validators.required],
      tx_Correo: [tx_Correo, Validators.required],
      tx_Telefono: [tx_Telefono],
      tx_Direccion: [tx_Direccion],
     // fe_Naciemiento: [''],
      co_Genero: [co_Genero, Validators.pattern("^[0-9]*$")]
      
    }),
    co_Perfil: [co_Perfil,Validators.required],
    tx_Username: [tx_Username,Validators.required],
    co_Situacion: [co_Situacion,Validators.required]
  //  email: ['', [Validators.required, Validators.email]],
   // message: ['']
  });
  }
  __insertarUsuario() {
    
    this.us.__UsuarioInsert(this.registroUsuarioForm.getRawValue()).subscribe((rest: any) => {
     // this.lstTipoDocumento =  rest.data;
     if (rest.isSuccess){
     
      alert('Se registro con exito');
     } else{
      alert('Error al registrar!!!');
     }
     console.log(rest);
     
    })
  }
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
  __GetConsultarUsuarioPorDatosPersonav2(tipoDoc: any, numDoc: any) {
    

    this.us.__getUsuarioPorDocumentosPersona(tipoDoc,numDoc).subscribe((rest: any) => {
     // this.lstTipoDocumento =  rest.data;
      if (rest.isSuccess && rest.data != null) {
        this.__poblarInfoRegistroUsuario(
          rest.data.co_Tipo_Doc
        , rest.data.tx_Numero_Documento
        , rest.data.tx_Nombre_Completo
        , rest.data.tx_Correo
        , rest.data.tx_Telefono
        , rest.data.tx_Direccion
        , rest.data.co_Genero
    
        , rest.data.co_Usuario
        , rest.data.co_Persona
        , rest.data.co_Perfil
        , rest.data.tx_Username
        , rest.data.co_Situacion
        ,''
       );
      }
    
      
    })
  }
  __GetConsultarUsuarioPorDatosPersona() {
    

    this.us.__getUsuarioPorDocumentosPersona(this.registroUsuarioForm.getRawValue().persona.co_Tipo_Doc,this.registroUsuarioForm.getRawValue().persona.tx_Numero_Documento).subscribe((rest: any) => {
     // this.lstTipoDocumento =  rest.data;
      if (rest.isSuccess && rest.data != null) {
        this.__poblarInfoRegistroUsuario(
          rest.data.co_Tipo_Doc
        , rest.data.tx_Numero_Documento
        , rest.data.tx_Nombre_Completo
        , rest.data.tx_Correo
        , rest.data.tx_Telefono
        , rest.data.tx_Direccion
        , rest.data.co_Genero
    
        , rest.data.co_Usuario
        , rest.data.co_Persona
        , rest.data.co_Perfil
        , rest.data.tx_Username
        , rest.data.co_Situacion
        ,''
       );
      }
    
      
    })
  }

  __onSubmit() {
    if(this.registroUsuarioForm.valid) {

      if (this.registroUsuarioForm.getRawValue().co_Usuario != null && this.registroUsuarioForm.getRawValue().co_Usuario != 0 ) {
        alert('Actualizando');
      } else {
        console.log(this.registroUsuarioForm.value);
        this.__insertarUsuario();
      }
 
    } else {
      alert('Formulario no valido!!!');
    }
  }
  ngOnInit(): void {
    //Maestra.
   // this.registroUsuarioForm.controls['persona.co_Tipo_Doc'].setValue("2");

   // console.log(this.registroUsuarioForm.getRawValue().persona.co_Tipo_Doc)
   this.ar.params.subscribe((params: Params) => {
      if(params.tipoDoc != null && params.numDoc != null){
        this.__GetConsultarUsuarioPorDatosPersonav2(params.tipoDoc,params.numDoc);
      }
   });
    this.__getMaestraTipoDocumento('TIPO_DOCUMENTO');
 
  }

}
