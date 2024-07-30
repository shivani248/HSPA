import { Component } from '@angular/core';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';
import { isPlatformBrowser } from '@angular/common';
import { Inject, PLATFORM_ID } from '@angular/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent {

  loggedInUser !: null|string;
  userData: any;

  constructor(@Inject(PLATFORM_ID) private platformId: Object) { }

  ngOnInit(
  ) {}



  loggedIn():boolean{

    if (isPlatformBrowser(this.platformId)) {
      // Check if localStorage is available
      this.loggedInUser = localStorage.getItem('userName');
      return localStorage.getItem('token') !== null;
    }
    return false;
  }

  loggedout(){
   
    localStorage.removeItem('token');
    localStorage.removeItem('userName');
    Swal.fire({
      position: "bottom-end",
      icon: "success",
      title: "Logged Out Successfully! ",
      showConfirmButton: false,
      timer: 1500
    });
    // Swal.fire("SweetAlert2 is working!");
  }

}
