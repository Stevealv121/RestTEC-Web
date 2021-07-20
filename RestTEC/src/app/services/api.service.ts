import { Injectable } from '@angular/core';
import { LoginI } from '../models/login.interface';
import { ResponseI } from '../models/response.interface';
import { HttpClient , HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { MenuI } from '../models/menu.interface';
import { DataI } from '../models/data.interface';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  menu_url:string = "https://localhost:44386/api/Menu";
  constructor(private http:HttpClient) { }

  loginByEmail(form:LoginI):Observable<ResponseI>{
    return this.http.post<ResponseI>(this.menu_url,form)

  }

  getMenu():Observable<DataI>{

    const headerDict = {
      'Content-Type': 'application/json',
      'Accept': 'application/json',
      'Access-Control-Allow-Headers': 'Content-Type',
      'Access-Control-Allow-Origin': 'http://localhost:4200',
      'Access-Control-Allow-Credentials': 'true'
    }
    
    const requestOptions = {                                                                                                                                                                                 
      headers: new HttpHeaders(headerDict), 
    };

    return this.http.get<DataI>(this.menu_url,requestOptions);

  }

  getDish(id: string | null):Observable<DataI>{
    let dishId = "/" + id;
    let url = this.menu_url + dishId;
    return this.http.get<DataI>(url);

  }

  putDish(form:MenuI):Observable<ResponseI>{
    let dishId = "/" + form.id.toString();
    let url = this.menu_url + dishId;
    return this.http.put<ResponseI>(url, form);
  }

  deleteDish(form:MenuI):Observable<ResponseI>{
    let dishId = "/" + form.id.toString();
    let url = this.menu_url + dishId;
    const headerDict = {
      'Content-Type': 'application/json'
    }
    
    const requestOptions = {                                                                                                                                                                                 
      headers: new HttpHeaders(headerDict),
      body: form 
    };
    return this.http.delete<ResponseI>(url, requestOptions);

  }

  postDish(form:MenuI):Observable<ResponseI>{
    return this.http.post<ResponseI>(this.menu_url,form);
  }
}
