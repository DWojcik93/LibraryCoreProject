import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BookService } from '../book.service';

@Component({
  selector: 'app-book-create',
  templateUrl: './book-create.component.html',
  styleUrls: ['./book-create.component.css']
})
export class BookCreateComponent implements OnInit {
  
  form: FormGroup;
   
  constructor(
    public postService: BookService,
    private router: Router
  ) { }
  
  ngOnInit(): void {
    this.form = new FormGroup({
      author: new FormControl('', [Validators.required]),
      title: new FormControl('', Validators.required),
      bookCode: new FormControl('', Validators.required),
      category: new FormControl('', Validators.required),
      pages: new FormControl('', Validators.required),
      rate: new FormControl('', Validators.required),
    });
  }
   
  get f(){
    return this.form.controls;
  }
    
  submit(){
    this.postService.createBook(this.form.value).subscribe(res => {
         console.log('Book created successfully!');
         this.router.navigateByUrl('book/index');
    })
  }
}
