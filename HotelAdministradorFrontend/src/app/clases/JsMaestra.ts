
export class JsMaestra {

    co_Maestra: number;
    tx_Maestra: string;
    nu_Codigo : number;
    tx_Descripcion : string;
    tx_Valor_General01 : string;
    tx_Valor_General02 : string;
    tx_Valor_General03 : string;
    tx_Valor_General04 : string;
    tx_Valor_General05 : string;
    fl_Estado : string;
    datoNuevo : string;// 01/01/2021

    constructor() {
        this.co_Maestra = 0;
        this.tx_Maestra="";
        this.nu_Codigo = 0;
        this.tx_Descripcion ="";
        this.tx_Valor_General01 ="";
        this.tx_Valor_General02 ="";
        this.tx_Valor_General03 ="";
        this.tx_Valor_General04 ="";
        this.tx_Valor_General05 ="";
        this.fl_Estado ="";
        this.datoNuevo ="";// 01/01/2021
    }

}
export interface RootListaMaestra{
    isSuccess: boolean;
    errorCode: "";
    errorMessage: "";
    data: JsMaestra[];
}
export interface RootObjectMaestra {
    isSuccess: boolean;
    errorCode: "";
    errorMessage: "";
    data: JsMaestra;
  }
  