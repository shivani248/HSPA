import { Component } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';

import { RegisterUser } from '../../../model/user';
// import { error } from 'console';
// import * as alertyfy from 'alertifyjs';
import Swal from 'sweetalert2';
import { AuthService } from '../../../services/auth.service';

// or via CommonJS


@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrl: './user-register.component.css',
  providers:[AuthService]
})
export class UserRegisterComponent {
  registrationForm!:FormGroup;
  user! : RegisterUser;
  userSubmitted!:boolean;
  constructor(private fb:FormBuilder , private authservice:AuthService){}; //Form builder is a class that helps to create reactive form
  ngOnInit() {
  // this.registrationForm = new FormGroup(
  //   {
  //   userName:new FormControl('Shivani', Validators.required),
  //   email: new FormControl(null, [Validators.required , Validators.email]),
  //   password: new FormControl(null, [Validators.required , Validators.minLength(8)]),
  //   confirmPassword: new FormControl(null, [Validators.required ]),
  //   mobNumber: new FormControl(null, [Validators.required , Validators.maxLength(10)]),
  // } ,  this.passwordMatchingValidator );
   this.registrationFormBuilder();
  }

  registrationFormBuilder(){
    this.registrationForm = this.fb.group({
      userName : [null, Validators.required],
      email:[null, [Validators.required , Validators.email]],
      password:[null , [Validators.required , Validators.minLength(8)]],
      confirmPassword:[null, Validators.required ],
      mobNumber:[null, [Validators.required , Validators.maxLength(10)]]
    } , {validators:this.passwordMatchingValidator});
  }

  passwordMatchingValidator(control:AbstractControl) : ValidationErrors|null{ //fg is a control tha we are passing
    return control.get('password')?.value === control.get('confirmPassword')?.value  ? null  :  {notMatched: true};

  }

//...........................................
// Getter method for all form controls
//...........................................

  get userName(){
    return this.registrationForm.get('userName') as FormControl;
  }

  get email(){
    return this.registrationForm.get('email') as FormControl;
  }
 
  get password(){
    return this.registrationForm.get('password') as FormControl;
  }

  get confirmPassword(){
    return this.registrationForm.get('confirmPassword') as FormControl;
  }

  get mobNumber(){
    return this.registrationForm.get('mobNumber') as FormControl;
  }

  onSubmit(){
    console.log(this.registrationForm.value);
    this.userSubmitted = true;
    if(this.registrationForm.valid){
      // this.user = Object.assign(this.user , this.registrationForm.value);
      // localStorage.setItem('User' , JSON.stringify(this.user))

      this.authservice.registerUser(this.userData()).subscribe(()=>{
        this.registrationForm.reset();
        this.userSubmitted = false;
        Swal.fire({
          title: 'Success!',
          text: 'Do you want to continue',
          icon: 'success'
        })
      });
      
    }

    else{
      Swal.fire({
        title: 'Error!',
        text: 'Account does not exits , try something else',
        icon: 'error'})
    }
  }

  userData():RegisterUser{
    return this.user ={
      userName:this.userName.value,
      email:this.email.value,
      password:this.password.value,
      mobile:this.mobNumber.value
    }

  }

//   addUser(user: any) {
//     let users = [];
//     const storedUsers = localStorage.getItem('Users');
//     if (storedUsers !== null) {
//         users = JSON.parse(storedUsers);
//         users = [user, ...users];
//     } else {
//         users = [user];
//     }
//     localStorage.setItem('Users', JSON.stringify(users)); // Change 'User' to 'Users'
// }


}
