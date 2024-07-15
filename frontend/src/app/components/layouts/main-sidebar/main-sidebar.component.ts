import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { AuthService } from '../../../services/auth.service';
import { Menus } from '../../../menu';
import { FormsModule } from '@angular/forms';
import { MenuPipe } from '../../../pipes/menu.pipe';

@Component({
  selector: 'app-main-sidebar',
  standalone: true,
  imports: [RouterLink, RouterLinkActive, FormsModule, MenuPipe],
  templateUrl: './main-sidebar.component.html',
  styleUrl: './main-sidebar.component.css'
})
export class MainSidebarComponent {
  search :string="";
  menus=Menus;

  constructor(
    public auth:AuthService
  ){}

}

