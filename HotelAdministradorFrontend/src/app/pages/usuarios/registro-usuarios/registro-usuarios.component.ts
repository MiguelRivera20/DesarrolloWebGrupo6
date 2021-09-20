import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MaestraService } from 'src/app/services/maestra.service';

@Component({
  selector: 'app-registro-usuarios',
  templateUrl: './registro-usuarios.component.html',
  styleUrls: ['./registro-usuarios.component.css']
})
export class RegistroUsuariosComponent implements OnInit {

  lstTipoDocumento : any = [];

  constructor(
    private readonly ms : MaestraService,
    private ar: ActivatedRoute
  ) { }

  __getMaestraTipoDocumento(maestra: string) {
    const param = maestra;

    this.ms.__getMaestra(param).subscribe((rest: any) => {
      this.lstTipoDocumento = rest.data;
      console.log(this.lstTipoDocumento);
    })
  }

  ngOnInit(): void {
    //Maestra
    this.__getMaestraTipoDocumento('TIPO_DOCUMENTO');
  }

}
