import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { clearScreenDown } from "readline";
import { environment } from "../../environments/enviroment";
import { LoginUser, RegisterUser } from "../model/user";

@Injectable({
  providedIn:'root'
})

export class AuthService{
  baseUrl = environment.baseUrl;
  constructor(private http:HttpClient){}
  
  
  authUser(user:LoginUser){
    return this.http.post(this.baseUrl + '/Account/login', user);}

  registerUser(user:RegisterUser){
    return this.http.post(this.baseUrl + '/Account/register', user);}

  //   let UserArray  = [];

  //   const storedUsers = localStorage.getItem('Users');
  //     if (storedUsers !== null) {
  //         UserArray = JSON.parse(storedUsers)
  // }
  // // find for each eleemnt in araay it iterrates through the array
  // //idf  exits in the array then it will return a filter record otherwise it will return undefines

  //   return UserArray.find((p:any)=>p.email === user.email && p.password === user.password);
}



