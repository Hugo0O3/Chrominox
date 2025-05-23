import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { provideHttpClient } from '@angular/common/http';
import { MenuComponent } from './menu/menu.component';
import { GameComponent } from './game/game.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations:[
    MenuComponent,
    GameComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }