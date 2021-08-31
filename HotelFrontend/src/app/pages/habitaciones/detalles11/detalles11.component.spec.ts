import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Detalles11Component } from './detalles11.component';

describe('Detalles11Component', () => {
  let component: Detalles11Component;
  let fixture: ComponentFixture<Detalles11Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Detalles11Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Detalles11Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
