import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TavernViewComponent } from './tavern-view.component';

describe('TavernViewComponent', () => {
  let component: TavernViewComponent;
  let fixture: ComponentFixture<TavernViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TavernViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TavernViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
