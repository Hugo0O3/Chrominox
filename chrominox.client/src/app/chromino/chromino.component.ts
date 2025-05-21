import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-chromino',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './chromino.component.html',
  styleUrl: './chromino.component.css'
})
export class ChrominoComponent {
  @Input() colors: string[] = [];
}
