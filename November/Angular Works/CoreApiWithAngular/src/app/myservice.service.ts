import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';




export interface DBAngularAPI{
  uid:number;
  name:string;
  age:number;
  addr:string;
  email:string;
  photo:string;
  uname:string;
  password:string;
}

const apiUrl = 'http://localhost:5198/api/UserManagement/';

@Injectable({
  providedIn: 'root'
})

export class MyserviceService {

  constructor(private http:HttpClient) { }

  createUser(user:any,file:File): Observable<any>{                 //user - to get data from component
    const url = apiUrl + 'inserttab';

    const formData:FormData = new FormData(); //fromform

    //properites in the class UserCreateDTO(key)
    formData.append('name',user.name);
    formData.append('age',user.age.toString());
    formData.append('addr',user.addr);
    formData.append('email',user.email);
    formData.append('uname',user.uname);
    formData.append('password',user.password);

    if(file){
      formData.append('path',file);
    }
    return this.http.post(url,formData);
    
  }

  login(credentials:any): Observable<any>{
    return this.http.post(apiUrl + 'logintab',credentials);
  }

  getProfile(id:any):Observable<any>{
    return this.http.get<DBAngularAPI>(apiUrl + 'gettabwithid/' +id);
  }
}
