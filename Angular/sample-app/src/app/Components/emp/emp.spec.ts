import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Emp } from './emp';

describe('Emp', () => {
  let component: Emp;
  let fixture: ComponentFixture<Emp>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [Emp]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Emp);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
