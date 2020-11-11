import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';

import { IBook } from './book';

@Injectable({
    providedIn: 'root'
})
export class BookService {

    //private urlAddress: string = 'http://localhost:50741/books';
    private urlAddress: string = 'https://localhost:44360/books';
    constructor(private http: HttpClient) { }

    public getBooks(): Observable<IBook[]> {
        return this.http.get<IBook[]>(this.urlAddress).pipe(
            tap(data => console.log('All: ' + JSON.stringify(data))),
            catchError(this.handleError)
        );
    }

    private handleError(err: HttpErrorResponse): Observable<never> {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        let errorMessage = '';
        if (err.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            errorMessage = `An error occurred: ${err.error.message}`;
        } else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
        console.error(errorMessage);
        return throwError(errorMessage);
    }

    // public getBooks(): IBook[] {
    //     return [
    //         {
    //             "bookId": 1,
    //             "title": "Hobbit",
    //             "author": "John Ronald Reuel Tolkien",
    //             "pages": 320,
    //             "category": "SciFi",
    //             "isAvailable": true,
    //             "starRating": 5.2,
    //             "bookCode": "115-BCD",
    //             "imageUrl": "assets/images/hobbit.png"
    //         },
    //         {
    //             "bookId": 2,
    //             "title": "Zielona Mila",
    //             "author": "Stephen Edwin King",
    //             "pages": 416,
    //             "category": "SciFi",
    //             "isAvailable": true,
    //             "starRating": 5.8,
    //             "bookCode": "115-BCD",
    //             "imageUrl": "assets/images/the-green-mile.png"
    //         },
    //         {
    //             "bookId": 5,
    //             "title": "Lśnienie",
    //             "author": "Stephen Edwin King",
    //             "pages": 520,
    //             "category": "Horror",
    //             "isAvailable": false,
    //             "starRating": 5.3,
    //             "bookCode": "A05-78D",
    //             "imageUrl": "assets/images/the-shining.png"
    //         },
    //         {
    //             "bookId": 8,
    //             "title": "Pan Taduesz",
    //             "author": "Adma Mickiewicz",
    //             "pages": 304,
    //             "category": "Novel",
    //             "isAvailable": false,
    //             "starRating": 5.0,
    //             "bookCode": "30A-10B",
    //             "imageUrl": "assets/images/pan-tadeusz.png"
    //         },
    //         {
    //             "bookId": 10,
    //             "title": "Sonety Krymskie",
    //             "author": "Adma Mickiewicz",
    //             "pages": 32,
    //             "category": "Novel",
    //             "isAvailable": true,
    //             "starRating": 4.2,
    //             "bookCode": "296-997",
    //             "imageUrl": "assets/images/sonety-krymskie.png"
    //         }
    //     ];
}
