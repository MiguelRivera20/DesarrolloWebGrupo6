import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Detalles9Component } from './detalles9.component';

describe('Detalles9Component', () => {
  let component: Detalles9Component;
  let fixture: ComponentFixture<Detalles9Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Detalles9Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Detalles9Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
