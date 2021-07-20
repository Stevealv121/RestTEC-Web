import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { MenuI } from '../models/menu.interface';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-new-dish',
  templateUrl: './new-dish.component.html',
  styleUrls: ['./new-dish.component.css']
})
export class NewDishComponent implements OnInit {

  newForm = new FormGroup({
    id: new FormControl(''),
    name: new FormControl(''),
    description: new FormControl(''),
    price: new FormControl(''),
    calories: new FormControl(''),
    type:new FormControl('')
  })

  constructor(private api:ApiService, private router:Router) { }

  ngOnInit(): void {
  }

  postForm(form:MenuI){
    this.api.postDish(form).subscribe(data =>{
      console.log(data);
    });
    this.leave();
  }

  leave(){
    this.router.navigate(['menu']);
  }
}
