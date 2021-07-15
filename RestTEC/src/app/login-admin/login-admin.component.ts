import { Component, OnInit } from '@angular/core';

import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ApiService } from '../services/api.service';
import { LoginI } from '../models/login.interface';

@Component({
  selector: 'app-login-admin',
  templateUrl: './login-admin.component.html',
  styleUrls: ['./login-admin.component.css']
})
export class LoginAdminComponent implements OnInit {

  loginForm = new FormGroup({
    email : new FormControl('',Validators.required),
    password : new FormControl('',Validators.required)
  })

  constructor(private api:ApiService) { }

  ngOnInit(): void {
  }

  onLogin(form: LoginI){
    this.api.loginByEmail(form).subscribe(data =>{
      console.log(data)
    })
    
  }

}
