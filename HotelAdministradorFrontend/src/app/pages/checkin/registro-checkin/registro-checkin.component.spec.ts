import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroCheckinComponent } from './registro-checkin.component';

describe('RegistroCheckinComponent', () => {
  let component: RegistroCheckinComponent;
  let fixture: ComponentFixture<RegistroCheckinComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistroCheckinComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistroCheckinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
