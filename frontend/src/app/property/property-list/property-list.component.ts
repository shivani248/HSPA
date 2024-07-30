
import { Component } from '@angular/core';
import { OnInit } from '@angular/core';
import { HousingService } from '../../services/housing.service';
import { error } from 'console';
import { ActivatedRoute, Router } from '@angular/router';
import { IPropertyBase } from '../../model/IpropertyBase';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrl: './property-list.component.css'
})
export class PropertyListComponent implements OnInit {

  SellRent = 1;
  properties! :Array<IPropertyBase>;
  Today:Date = new Date();
  City!:'';
  SearchCity = '';
  SortbyParam = '';
  SortDirection = 'asc';
  
  constructor(private route:ActivatedRoute ,private houseservice:HousingService){}

  ngOnInit():void {

    if(this.route.snapshot.url.toString()){
      this.SellRent = 2; // means we are on rent-propery url or else on base url
    }
    this.houseservice.getAllProperties(this.SellRent).subscribe(
      data=>{
        this.properties = data;
        console.log(data,"fgdfFFF" );
        console.log( "path" , this.route.snapshot.url.toString());
      })
  }

  onCityFilter() {
    this.SearchCity = this.City;
  }

  onCityFilterClear() {
    this.SearchCity = '';
    this.City = '';
  }

  onSortDirection() {
    if (this.SortDirection === 'desc') {
      this.SortDirection = 'asc';
    } else {
      this.SortDirection = 'desc';
    }
  }


    //  this.http.get("data/properties.json").subscribe(
    //   data=>{
    //     this.properties = data;
    //     console.log(data);
    //   }
    //  );





}
