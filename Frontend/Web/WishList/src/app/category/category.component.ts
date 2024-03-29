import { Component, OnInit } from '@angular/core';
import { CategoryService } from './category.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    console.log('logging...');
  }

  myFunction() {
    alert('click c');
    
    this.categoryService.getCategories().subscribe((data : any) => {
      console.log(data);
    });

    console.log('click c...');
  }
}
