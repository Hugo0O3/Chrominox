import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ChrominoComponent } from './chromino/chromino.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterModule, ChrominoComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'chrominox';
}