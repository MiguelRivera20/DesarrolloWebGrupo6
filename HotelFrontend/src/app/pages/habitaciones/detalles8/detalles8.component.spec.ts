import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Detalles8Component } from './detalles8.component';

describe('Detalles8Component', () => {
  let component: Detalles8Component;
  let fixture: ComponentFixture<Detalles8Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Detalles8Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Detalles8Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
