import { Component, Input, Output , EventEmitter} from '@angular/core';
import { Property } from '../../model/property';
import { HousingService } from '../../services/housing.service';
import { Photo } from '../../model/photo';
import { environment } from '../../../environments/enviroment';
import { FileUploader } from 'ng2-file-upload';


@Component({
  selector: 'app-photo-editor',
  templateUrl: './photo-editor.component.html',
  styleUrl: './photo-editor.component.css'
})
export class PhotoEditorComponent {
  @Input() property! : Property;
 @Output() mainPhotoChangedEvent = new EventEmitter<string>();
 uploader!: FileUploader;
//  hasBaseDropZoneOver: boolean;
 baseUrl = environment.baseUrl;
 maxAllowedFileSize=1*1024*1024;


  constructor(private housingService: HousingService) {}
  ngOnInit() {
    console.log("property hai ",this.property);
    
    this.initializeFileUploader();
  }

 
  initializeFileUploader() {
    console.log("iddddd",this.property.id);
    this.uploader = new FileUploader({
        url: this.baseUrl +'/Property/add/photo/'+ String(this.property.id),
        authToken: 'Bearer '+ localStorage.getItem('token'),
        isHTML5: true,
        allowedFileType: ['image'],
        removeAfterUpload: true,
        autoUpload: true,
        maxFileSize:this.maxAllowedFileSize
      });


      this.uploader.onAfterAddingFile = (file) => {
        file.withCredentials = false;};

      this.uploader.onSuccessItem=(item , response , status , Headers)=>{
        console.log(response);
        
      }
  }
  
    mainPhotoChanged(url:string){
      this.mainPhotoChangedEvent.emit(url);
    }

 
  setPrimaryPhoto(propertyId: number, photo:Photo){
    this.housingService.setPrimaryPhoto(propertyId,photo.publicId).subscribe(()=>{
      this.mainPhotoChanged(photo.imageUrl);
            this.property.photos?.forEach(p => {
                if (p.isPrimary) {p.isPrimary = false;}
                if (p.publicId === photo.publicId) {p.isPrimary = true;}
            });
    });

  }

  deletePhoto(propertyId: number, photo: Photo) {
    this.housingService.deletePhoto(propertyId,photo.publicId).subscribe(()=>{
        this.property.photos = this.property.photos?.filter(p =>
            p.publicId !== photo.publicId);
    });
}

}
