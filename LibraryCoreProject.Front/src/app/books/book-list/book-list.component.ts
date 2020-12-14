import { Component, OnInit } from '@angular/core';
import { IBook } from '../book';
import { BookService } from '../book.service';

@Component({
    selector: 'pm-books',
    templateUrl: './book-list.component.html',
    styleUrls: ['./book-list.component.css']
})

export class BookListComponent implements OnInit {
    pageTitle: any = "Books list";
    imageWidth: any = 50;
    imageMargin: any = 2;
    showImage: boolean = false;
    errorMessage: string;

    private _listFilter: string;
    public get listFilter(): string {
        return this._listFilter;
    }
    public set listFilter(value: string) {
        this._listFilter = value;
        this.filteredBooks = this.listFilter ? this.performFilter(this.listFilter) : this.books;
    }


    filteredBooks: IBook[];
    books: IBook[] = [];

    constructor(private bookService: BookService) {
        this.listFilter = "";
    }

    performFilter(filterBy: string): IBook[] {
        filterBy = filterBy.toLocaleLowerCase();
        return this.books.filter((book: IBook) =>
            book.title.toLocaleLowerCase().indexOf(filterBy) !== -1);
    }

    onRatingClicked(message: string): void {
        this.pageTitle = 'Books list: ' + message;
    }

    toggleImage(): void {
        this.showImage = !this.showImage;
    }

    ngOnInit(): void {
        this.bookService.getBooks().subscribe({
            next: books => {
                this.books = books;
                this.filteredBooks = this.books;
            },
            error: err => this.errorMessage = err
        });
    }

    deleteBook(id) {
        this.bookService.deleteBook(id).subscribe(res => {
            this.books = this.books.filter(item => item.id !== id);
            console.log('Book deleted successfully!');
        })
    }
}