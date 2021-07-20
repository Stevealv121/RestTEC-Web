import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { MenuI } from '../models/menu.interface';
import { ApiService } from '../services/api.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { DataI } from '../models/data.interface';

@Component({
  selector: 'app-edit-menu',
  templateUrl: './edit-menu.component.html',
  styleUrls: ['./edit-menu.component.css']
})
export class EditMenuComponent implements OnInit {

  constructor(private activerouter:ActivatedRoute, private router:Router, private api:ApiService) { }

  dataMenu: MenuI | undefined;
  editForm = new FormGroup({
    id: new FormControl(''),
    name: new FormControl(''),
    description: new FormControl(''),
    price: new FormControl(''),
    calories: new FormControl(''),
    type:new FormControl('')
  })

  ngOnInit(): void {
    let dishid = this.activerouter.snapshot.paramMap.get('id');
    let token = this.getToken();
    this.api.getDish(dishid).subscribe(data =>{
      this.dataMenu = data.data;
      this.editForm.setValue({
        'id' : this.dataMenu?.id,
        'name' : this.dataMenu?.name,
        'description' : this.dataMenu?.description,
        'price' : this.dataMenu?.price,
        'calories' : this.dataMenu?.calories,
        'type' : this.dataMenu?.type
      });
      console.log(this.editForm.value);
    });
  }

  getToken(){
    return localStorage.getItem('token');
  }

  postForm(form:MenuI){
    this.api.putDish(form).subscribe(data =>{
      console.log(data);
    })
  }

  delete(){
    let data:MenuI = this.editForm.value;
    this.api.deleteDish(data).subscribe(data =>{
      console.log(data)
    });
    this.leave();
  }

  leave(){
    this.router.navigate(['menu']);
  }

}
