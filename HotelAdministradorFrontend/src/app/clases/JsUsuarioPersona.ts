
export class JsUsuarioPersona {

    
    co_Usuario: number;
    co_Perfil: number;
    tx_Username: string;
    co_Situacion: number;
    fe_registro_str: string;
    tx_nombre_perfil: string;
    co_Persona: number;
    co_Tipo_Persona: number;
    co_Tipo_Doc : number;
    tx_Numero_Documento : string;
    tx_Nombre_Completo : string;
    tx_Correo : string;
    tx_Telefono : string;
    tx_Direccion : string;
    fe_Naciemiento_str : string;
    co_Genero : number;
    tx_Situacion_Nombre: string;
    
    constructor() {

        this.co_Usuario= 0;
        this.co_Perfil= 0;
        this.tx_Username= "";
        this.co_Situacion= 0;
        this.co_Persona = 0;
        this.co_Tipo_Persona=0;
        this.co_Tipo_Doc = 0;
        this.tx_Numero_Documento ="";
        this.tx_Nombre_Completo ="";
        this.tx_Correo ="";
        this.tx_Telefono ="";
        this.tx_Direccion ="";
        this.fe_Naciemiento_str ="";
        this.co_Genero =0;
        this.fe_registro_str = "";
        this.tx_nombre_perfil = "";
        this.tx_Situacion_Nombre = "";
    }

}
export interface RootListaUsuarioPersona{
    isSuccess: boolean;
    errorCode: "";
    errorMessage: "";
    data: JsUsuarioPersona[];
}
export interface RootObjectUsuarioPersona {
    isSuccess: boolean;
    errorCode: "";
    errorMessage: "";
    data: JsUsuarioPersona;
  }
  