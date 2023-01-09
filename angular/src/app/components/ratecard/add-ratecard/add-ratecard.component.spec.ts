import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddRatecardComponent } from './add-ratecard.component';

describe('AddRatecardComponent', () => {
  let component: AddRatecardComponent;
  let fixture: ComponentFixture<AddRatecardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddRatecardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddRatecardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
