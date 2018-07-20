import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrRemoveReviewComponent } from './add-or-remove-review.component';

describe('AddOrRemoveReviewComponent', () => {
  let component: AddOrRemoveReviewComponent;
  let fixture: ComponentFixture<AddOrRemoveReviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddOrRemoveReviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddOrRemoveReviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
