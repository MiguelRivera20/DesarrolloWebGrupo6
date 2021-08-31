import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Detalles7Component } from './detalles7.component';

describe('Detalles7Component', () => {
  let component: Detalles7Component;
  let fixture: ComponentFixture<Detalles7Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Detalles7Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Detalles7Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
