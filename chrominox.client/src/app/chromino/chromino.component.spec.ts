import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChrominoComponent } from './chromino.component';

describe('ChrominoComponent', () => {
  let component: ChrominoComponent;
  let fixture: ComponentFixture<ChrominoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ChrominoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChrominoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
