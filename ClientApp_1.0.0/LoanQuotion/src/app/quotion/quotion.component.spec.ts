import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuotionComponent } from './quotion.component';

describe('QuotionComponent', () => {
  let component: QuotionComponent;
  let fixture: ComponentFixture<QuotionComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [QuotionComponent]
    });
    fixture = TestBed.createComponent(QuotionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
