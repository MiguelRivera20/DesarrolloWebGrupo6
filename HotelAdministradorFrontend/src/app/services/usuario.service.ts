import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private readonly http: HttpClient) { }

  __UsuarioInsert(data : any) {
   console.log("data");
   console.log(JSON.stringify(data));
   var data2 = "";
    return this.http.post<any>('https://localhost:44309/api/usuario/insert', data,{});
  }


  __getUsuarioPorDocumentosPersona(tipoDoc: number, numeroDoc: string) {
    // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra='+ params);
   // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra=TIPO_DOCUMENTO');
      return this.http.get('https://localhost:44309/api/usuario/getUsuarioPorDocumentoPersona?tipoDocumento='+ tipoDoc+'&numeroDocumento='+numeroDoc);
   }

   __listarUsuariosPorfiltro(coPerfil: number, username: string) {
    // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra='+ params);
   // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra=TIPO_DOCUMENTO');
      return this.http.get('https://localhost:44309/api/usuario/listarUsuariosPorfiltro?coPerfil='+ coPerfil+'&username='+username);
   }

}
