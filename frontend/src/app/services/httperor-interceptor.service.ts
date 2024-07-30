import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, throwError } from "rxjs";
import Swal from 'sweetalert2';


@Injectable({
    providedIn: 'root'
})
export class HttpErrorInterceptorService implements HttpInterceptor {
    intercept(request: HttpRequest<any>, next: HttpHandler) {
        console.log('HTTP Request started');
        return next.handle(request)
        .pipe(
            catchError((error: HttpErrorResponse) => {
                const errorMessage = this.setError(error);
                console.log(error);
                Swal.fire(errorMessage);
             throw errorMessage;
            })
        );
    
    }

    setError(error: HttpErrorResponse): string {
        let errorMessage = 'Unknown error occured';
        if(error.error instanceof ErrorEvent) {
            // Client side error
            errorMessage = error.error.message;
        } else {

            if(error.status ===401){
                return error.statusText;
            }
            // server side error
            if (error.error.errorMessage && error.error && error.status!==0) {
                errorMessage = error.error;
            }
        }
        return errorMessage;
    }

}