import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { IProperty } from '../model/iproperty';
import { environment } from "../../environments/enviroment";
import { Property } from '../model/property';
import { IPropertyBase } from '../model/IpropertyBase';
import { Ikeyvaluepair } from '../model/ikeyvalupair';

@Injectable({
  providedIn: 'root'
})
export class HousingService {
  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient) { }

  getAllCities():Observable<string[]>{
    return this.http.get<string[]>(this.baseUrl+'/City/cities');
  }
 
  getPropertyTypes(): Observable<Ikeyvaluepair[]> {
    return this.http.get<Ikeyvaluepair[]>(this.baseUrl + '/propertytype/list');
}

getFurnishingTypes(): Observable<Ikeyvaluepair[]> {
    return this.http.get<Ikeyvaluepair[]>(this.baseUrl + '/furnishingtype/list');
}

  getProperty(id: number) {
    return this.http.get<Property>(this.baseUrl + '/Property/detail/'+id.toString());
    // return this.getAllProperties(1).pipe( 
    //   map(propertiesArray => {
    //     return propertiesArray.find(p => p.id === id);
    //   })
    // );
  }

  getAllProperties(SellRent?: number): Observable<IPropertyBase[]> {

    return this.http.get<Property[]>(this.baseUrl+'/Property/list/'+SellRent?.toString());
    // return this.http.get('data/properties.json').pipe(
    //   map((data:any) => {
    //   const propertiesArray: Array<IPropertyBase> = [];
    //   const localProperties = JSON.parse(localStorage.getItem('newProp')!);


    //   if (localProperties) {
    //     for (const id in localProperties) {
    //       if (SellRent) {
    //       if (localProperties.hasOwnProperty(id) && localProperties[id].SellRent === SellRent) {
    //         propertiesArray.push(localProperties[id]);
    //       }
    //     } else {
    //       propertiesArray.push(localProperties[id]);
    //     }
    //     }
    //   }

    //   for (const id in data) {
    //     if (SellRent) {
    //       if (data.hasOwnProperty(id) && data[id].SellRent === SellRent) {
    //         propertiesArray.push(data[id]);
    //       }
    //       } else {
    //         propertiesArray.push(data[id]!);
    //     }
    //   }
    //   return propertiesArray;
    //   })
    // );

    // return this.http.get<IProperty[]>('data/properties.json');
  }

  getPropertyAge(dateofEstablishment: Date): string
  {
      const today = new Date();
      const estDate = new Date(dateofEstablishment);
      let age = today.getFullYear() - estDate.getFullYear();
      const m = today.getMonth() - estDate.getMonth();

      // Current month smaller than establishment month or
      // Same month but current date smaller than establishment date
      if (m < 0 || (m === 0 && today.getDate() < estDate.getDate())) {
          age --;
      }

      // Establshment date is future date
      if(today < estDate) {
          return '0';
      }

      // Age is less than a year
      if(age === 0) {
          return 'Less than a year';
      }

      return age.toString();
  }

  addProperty(property: Property) {
    const token = localStorage.getItem('token');
  
    // Check if the token is present
    if (!token) {
      console.error('Token not found in localStorage');
      return;
    }
  
    // Create the HttpHeaders with the Authorization header
    const httpOptions = {
      headers: new HttpHeaders({
        'Authorization': `Bearer ${token}`
      })
    };
   return this.http.post('https://localhost:7095/api'+'/Property/add',property,httpOptions);
  }
  

    //---stroring in local storage-----------
    // let newProp = [property];

    // Add new property in array if newProp alreay exists in local storage
    // if (localStorage.getItem('newProp')) {
    //   newProp = [property,
    //               ...JSON.parse(localStorage.getItem('newProp')!)];
    // }

    // localStorage.setItem('newProp', JSON.stringify(newProp));
  

  newPropID() {
    if (localStorage.getItem('PID')) {
      localStorage.setItem('PID', String(+localStorage.getItem('PID')! + 1));
      return +localStorage.getItem('PID')!;
    } else {
      localStorage.setItem('PID', '101');
      return 101;
    }
  }

  setPrimaryPhoto(propertyId: number, propertyPhotoId: string) {
    const httpOptions = {
        headers: new HttpHeaders({
            Authorization: 'Bearer '+ localStorage.getItem('token')
        })
    };
    return this.http.post(this.baseUrl + '/Property/set-primary-photo/'+String(propertyId)
        +'/'+propertyPhotoId, {}, httpOptions);
  }

  deletePhoto(propertyId: number, propertyPhotoId: string) {
      const httpOptions = {
          headers: new HttpHeaders({
              Authorization: 'Bearer '+ localStorage.getItem('token')
          })
      };
      return this.http.delete(this.baseUrl + '/Property/delete-photo/'
      +String(propertyId)+'/'+propertyPhotoId, httpOptions);
  }

}
