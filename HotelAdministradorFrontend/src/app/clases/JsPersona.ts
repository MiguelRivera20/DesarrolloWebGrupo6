
export class JsPersona {

    co_Persona: number;
    co_Tipo_Persona: number;
    co_Tipo_Doc : number;
    tx_Numero_Documento : string;
    tx_Nombre_Completo : string;
    tx_Correo : string;
    tx_Telefono : string;
    tx_Direccion : string;
    fe_Naciemiento : string;
    co_Genero : number;

    constructor() {
        this.co_Persona = 0;
        this.co_Tipo_Persona=0;
        this.co_Tipo_Doc = 0;
        this.tx_Numero_Documento ="";
        this.tx_Nombre_Completo ="";
        this.tx_Correo ="";
        this.tx_Telefono ="";
        this.tx_Direccion ="";
        this.fe_Naciemiento ="";
        this.co_Genero =0;
    }

}
export interface RootListaPersona{
    isSuccess: boolean;
    errorCode: "";
    errorMessage: "";
    data: JsPersona[];
}
export interface RootObjectPersona {
    isSuccess: boolean;
    errorCode: "";
    errorMessage: "";
    data: JsPersona;
  }
  