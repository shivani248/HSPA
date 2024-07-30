import { IPropertyBase } from "./IpropertyBase";
import { Photo } from "./photo";

export class Property implements IPropertyBase {
  id !: number ;
  sellRent!: number;
  name!: string;
  propertyType!: string;
  propertyTypeId!:number;
  bhk!: number;
  furnishingType!: string;
  furnishingTypeId!:number;
  price!: number;
  builtArea!: number;
  carpetArea?: number;
  address!: string;
  address2!: string;
  city!: string;
  cityId!: number;

  floorNo?: string;
  totalFloors?: string;
  readyToMove!: boolean;
  age?: string;
  mainEntrance!: string;
  security?: number;
  gated?: number;
  maintenance?: number;
  estPossessionOn? : Date ;
  photo?: string;
  description!: string;
  PostedOn!: string;
  PostedBy!: number;
  photos?:Photo[];
}