import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HousingService } from '../../../services/housing.service';
import { Property } from '../../../model/property';
import { IPropertyBase } from '../../../model/IpropertyBase';
import { GalleryItem } from '@daelmaak/ngx-gallery';
import { NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from '@kolkov/ngx-gallery';


@Component({
  selector: 'app-property-detail',
  templateUrl: './property-detail.component.html',
  styleUrls: ['./property-detail.component.css']
})
export class PropertyDetailComponent implements OnInit {
  galleryOptions!: NgxGalleryOptions[];
  galleryImages!: NgxGalleryImage[];
  public mainPhotoUrl!: string;
  public propertyId!: number;
  property!:Property;


// Example usage
// images: GalleryItem[] = [{ src: ['prop1.jpg', 'prop2.jpg' ]}]

  constructor(private route: ActivatedRoute,
              private router: Router,
              private housingService: HousingService) { }

  ngOnInit() {
    this.propertyId = +this.route.snapshot.params['id'];

    this.route.params.subscribe(
      (params) => {
          this.propertyId = +params['id'];
          this.housingService.getProperty(this.propertyId).subscribe(
              (data: IPropertyBase | undefined) => {
                  if (data) {
                      // Handle the case when data is defined
                      this.property = data as Property; // Assuming Property extends IPropertyBase
                      this.property.age = this.housingService.getPropertyAge(this.property.estPossessionOn!);
                      console.log("photos",this.property.photos);
                      this.galleryImages = this.getPropertyPhotos();
                      
                  } else {
                      // Handle the case when data is undefined
                  }
              }
          );
         
      }
    );
 
     
 //----------------------------------------
  //GALLARY PHOTOS
  //-----------------------------------------
  this.galleryOptions = [
    {
      width: '100%',
      height: '465px',
      thumbnailsColumns: 4,
      imageAnimation: NgxGalleryAnimation.Slide
    },
    // max-width 800
  ];
  
  // this.galleryImages = this.getPropertyPhotos();
}

    getPropertyPhotos(): NgxGalleryImage[] {
      const photoUrls: NgxGalleryImage[] = [];  
      for(const photo of this.property.photos!){
        if(photo.isPrimary)
          {
              this.mainPhotoUrl = photo.imageUrl;
          }
          else{
              photoUrls.push(
                  {
                      small: photo.imageUrl,
                      medium: photo.imageUrl,
                      big: photo.imageUrl
                  }
              );}
      }
      console.log("iterable image",photoUrls);
      return photoUrls;
    }

    changePrimaryPhoto(mainPhotoUrl: string) {
      this.mainPhotoUrl = mainPhotoUrl;
  }

  }






