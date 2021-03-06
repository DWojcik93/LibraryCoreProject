import { HttpClient, HttpErrorResponse, HttpParams, HttpHeaders } from '@angular/common/http';
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
        return this.http.get<IBook[]>(this.urlAddress)
            .pipe(
                //tap(data => console.log('All: ' + JSON.stringify(data))),
                catchError(this.handleError)
            );
    }

    public getBook(id: number): Observable<IBook> {
        return this.http.get<IBook>(this.urlAddress + '/' + id)
            .pipe(
                catchError(this.handleError)
            );
    }

    public createBook(book: IBook): Observable<boolean>{
        const headers = new HttpHeaders().set('Content-Type','application/json');

        return this.http.post<boolean>(this.urlAddress, {book: book}, {headers: headers})
        .pipe(
            catchError(this.handleError)
        );
    }

    public deleteBook(id: number){
        return this.http.delete<IBook>(this.urlAddress + '/' + id)
        .pipe(
          catchError(this.handleError)
        )
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
}
