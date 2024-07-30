import { Component, Input } from "@angular/core";
import { IPropertyBase } from "../../model/IpropertyBase";
// import { IProperty } from "../IProperty.interface";

@Component({
selector:"app-property-card",
standalone: false,
// template:`<h1>I am a Card!!!!</h1>`
templateUrl:'property-card.component.html',
styleUrl:'property-card.component.css'
})

export class PropertyCardComponent{
@Input() property! :IPropertyBase;
@Input() hideIcons! : boolean;
// property:any = {
//    "id":1,
//     "home":"Birla House 1",
//     "price":4000,

// }


}
