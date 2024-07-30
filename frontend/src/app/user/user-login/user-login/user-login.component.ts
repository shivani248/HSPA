import { Component } from '@angular/core';

import { FormBuilder, FormControl, FormGroup, Validators, NgForm } from '@angular/forms';
import { AuthService } from '../../../services/auth.service';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';
import { LoginUser } from '../../../model/user';
@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrl: './user-login.component.css'
})
export class UserLoginComponent {

 constructor( private authService: AuthService,
              private router:Router){}
 ngOnInit() { }

    onLogin(loginForm : NgForm){
      console.log(loginForm.value);
      this.authService.authUser(loginForm.value).subscribe(
       response  =>  {
            console.log("This is response" , response);
            const user : LoginUser = response as LoginUser;
                    localStorage.setItem('token', user.token);
                    localStorage.setItem('userName', user.userName);
                    // this.alertify.success('Login Successful');
                    
                    this.router.navigate(['/']);
                }
          );
    // if(token){
    //   localStorage.setItem('token' , token.email) //it will set the toke othetrwise it eil return undefined
    //   console.log("login sucess");
    //   Swal.fire({
    //     title: "Login Successfully !!",
    //     width: 600,
    //     padding: "3em",
    //     color: "#716add",
    //     background: "#fff url(/images/trees.png)",
    //     backdrop: `
    //       rgba(0,0,123,0.4)
    //       url("/images/nyan-cat.gif")
    //       left top
    //       no-repeat
    //     `
    //   });
    //   this.router.navigate(['/']);
    // }
    // else{
    //   Swal.fire({
    //     icon: "error",
    //     title: "Oops...",
    //     text: "You do not have account ",
    //     // footer: '<a href="#">Why do I have this issue?</a>'
    //   });
    //   console.log("user not exits");

    // }
 }

}
