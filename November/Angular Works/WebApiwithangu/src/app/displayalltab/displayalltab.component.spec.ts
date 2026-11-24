import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayalltabComponent } from './displayalltab.component';

describe('DisplayalltabComponent', () => {
  let component: DisplayalltabComponent;
  let fixture: ComponentFixture<DisplayalltabComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DisplayalltabComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisplayalltabComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
