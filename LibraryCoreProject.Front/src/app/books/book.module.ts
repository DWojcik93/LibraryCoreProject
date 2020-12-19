import { NgModule } from '@angular/core';
import { BookDetailComponent } from './book-detail/book-detail.component';
import { BookListComponent } from './book-list/book-list.component';
import { RouterModule } from '@angular/router';
import { BookDetailGuard } from './book-detail/book-detail.guard';
import { SharedModule } from '../shared/shared.module';
import { BookCreateComponent } from './book-create/book-create.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    BookListComponent,
    BookDetailComponent,
    BookCreateComponent
  ],
  imports: [
    RouterModule.forChild([
      { path: 'books', component: BookListComponent },
      { path: 'books/create', component: BookCreateComponent },
      { path: 'books/:id', canActivate: [BookDetailGuard], component: BookDetailComponent },
    ]),
    SharedModule,
    ReactiveFormsModule
  ]
})
export class BookModule { }
