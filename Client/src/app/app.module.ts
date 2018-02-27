// core libraries.
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

// additional libraries.
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

// application components. 
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { NavbarComponent } from './navbar/navbar.component';
import { MainComponent } from './main/main.component';


@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    NavbarComponent,
    MainComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
