import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MaestraService {

  constructor(private readonly http: HttpClient) { }

  __getMaestra(params: any) {
   // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra='+ params);
  // return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra=TIPO_DOCUMENTO');
     return this.http.get('https://localhost:44309/api/maestra/getMaestra?maestra='+ params);
  }

  /*
  __getProject(params: any) {
    return this.http.get('https://localhost:44309/api/project/getproject' + params)
  }

  __adminInsert(data: any, headers :any) {
    return this.http.post<any>('https://localhost:44309/api/project/admin/insert', data, { headers });
  } */
}