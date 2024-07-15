import { Component } from '@angular/core';
import { ControlSidebarComponent } from './control-sidebar/control-sidebar.component';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { MainSidebarComponent } from './main-sidebar/main-sidebar.component';
import { FooterComponent } from './footer/footer.component';

@Component({
  selector: 'app-layouts',
  standalone: true,
  imports: [RouterOutlet, NavbarComponent, MainSidebarComponent, FooterComponent, ControlSidebarComponent],
  templateUrl: './layouts.component.html',
  styleUrl: './layouts.component.css'
})
export class LayoutsComponent {

}