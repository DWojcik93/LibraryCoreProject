import { Component, OnInit } from '@angular/core';
import { IBook } from './book';
import { ActivatedRoute, Router } from '@angular/router';
import { BookService } from './book.service';

@Component({
  templateUrl: './book-detail.component.html',
  styleUrls: ['./book-detail.component.css']
})
export class BookDetailComponent implements OnInit {
  pageTitle: string = 'Book Detail';
  errorMessage = '';
  book: IBook;
  constructor(private route: ActivatedRoute,
              private router: Router,
              private bookSerivce: BookService) { }

  ngOnInit(): void {
    const param = this.route.snapshot.paramMap.get('id');
    if (param) {
      const id = +param;
      this.getBook(id);
    }
  }

  getBook(id: number): void {
    console.log(id);
    this.bookSerivce.getBook(id).subscribe({
      next: book => this.book = book,
      error: err => this.errorMessage = err
    });
  }

  onBack(): void {
    this.router.navigate(['/books']);
  }
}
