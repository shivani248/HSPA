export interface IPropertyBase {
  id: number | null;
  sellRent: number| null;
  name: string;
  propertyType: string| null;
  furnishingType: string| null;
  price: number| null;
  bhk: number| null;
  builtArea: number| null;
  city: string| null;
  readyToMove: boolean |null;
  photo?: string;
  estPossessionOn? : Date ;
}
