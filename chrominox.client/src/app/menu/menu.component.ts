import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  standalone: false,
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  constructor(private router: Router) { }

  startGame() {
    this.router.navigate(['/game']);
  }

  quickGame() {
    this.router.navigate(['/quickGame'], { queryParams: { quick: true } });
  }

  quitGame() {
    if(confirm('Voulez-vous vraiment quitter le jeu ?')) {
      this.router.navigate(['/']);
      // window.close();
    }
  }
}
