import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ChrominoComponent } from './chromino/chromino.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterModule, ChrominoComponent],
  template: `
    <h1>Chrominox</h1>
    <app-chromino [colors]="chrominoColors"></app-chromino>
    <router-outlet></router-outlet>
  `
})
export class AppComponent {
  title = 'chrominox';
  chrominoColors: string[] = ['#FF0000', '#00FF00', '#0000FF'];
}