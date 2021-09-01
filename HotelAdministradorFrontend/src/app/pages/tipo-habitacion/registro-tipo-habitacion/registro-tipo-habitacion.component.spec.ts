import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroTipoHabitacionComponent } from './registro-tipo-habitacion.component';

describe('RegistroTipoHabitacionComponent', () => {
  let component: RegistroTipoHabitacionComponent;
  let fixture: ComponentFixture<RegistroTipoHabitacionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistroTipoHabitacionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistroTipoHabitacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
