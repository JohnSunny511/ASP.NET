import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InserttabComponent } from './inserttab.component';

describe('InserttabComponent', () => {
  let component: InserttabComponent;
  let fixture: ComponentFixture<InserttabComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InserttabComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InserttabComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
