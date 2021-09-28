import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  constructor(private readonly http: HttpClient) { }
  __getPersona(tipoDoc: number, numeroDoc: string) {
    // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra='+ params);
   // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra=TIPO_DOCUMENTO');
      return this.http.get('https://localhost:44309/api/persona/getNumeroAndTipoDoc?tipoDoc='+ tipoDoc+'&numeroDoc='+numeroDoc);
   }
}
