import { NgModule } from '@angular/core';
import { BookDetailComponent } from './book-detail.component';
import { BookListComponent } from './book-list.component';
import { RouterModule } from '@angular/router';
import { BookDetailGuard } from './book-detail.guard';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    BookListComponent,
    BookDetailComponent
  ],
  imports: [
    RouterModule.forChild([
      { path: 'books', component: BookListComponent },
      { path: 'books/:id', canActivate: [BookDetailGuard], component: BookDetailComponent },
    ]),
    SharedModule
  ]
})
export class BookModule { }
