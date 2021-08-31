import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Detalles10Component } from './detalles10.component';

describe('Detalles10Component', () => {
  let component: Detalles10Component;
  let fixture: ComponentFixture<Detalles10Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Detalles10Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Detalles10Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
