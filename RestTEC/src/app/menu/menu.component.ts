import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Router } from '@angular/router';
import { MenuI } from '../models/menu.interface';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  menu: MenuI[] = [];

  headers = ["#", "Name", "Description", "Price", "Calories", "Type"]

  constructor(private api:ApiService, private router:Router) { }

  ngOnInit(): void {
    this.api.getMenu().subscribe(data =>{
      this.menu = data;
      console.log(this.menu);
    })
  }

}
