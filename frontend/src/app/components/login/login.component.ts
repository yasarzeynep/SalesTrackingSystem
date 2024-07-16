import { Component } from '@angular/core';
import { LoginModel } from '../../models/login.model';
import { SharedModule } from '../../modules/shared.module';
import { HttpService } from '../../services/http.service';
import { Router } from '@angular/router';
import { LoginResponseModel } from '../../models/login.response.model';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  model:LoginModel=new LoginModel();
  //authService: any;

  constructor(
    private http: HttpService,
    private router: Router,
    private authService: AuthService 
    
  ){}

  signIn(){
    this.http.post<LoginResponseModel>("Auth/Login",this.model,(res)=> {
      localStorage.setItem("token", res.token);
      this.router.navigateByUrl("/");
    });
  }

 
}