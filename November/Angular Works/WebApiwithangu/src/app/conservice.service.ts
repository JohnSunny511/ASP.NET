import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';



export interface MVCWebApi{
  empId:number;
  empName: string;
  empAge:number;
  empSalary:number;
  empAddr:string;
}

const endpoint = "http://localhost:61454/api/API/";

@Injectable({
  providedIn: 'root'
})
export class ConserviceService {

  constructor(private http: HttpClient) { }

  addWebApiEmpTab(emp:any): Observable<any>{debugger;
    return this.http.post(endpoint + 'postwebapiemptab',emp);
  }

  getAllWebApiEmpTab(): Observable<any>{
    return this.http.get<MVCWebApi>(endpoint+'getalldata');
  }

  deleteWebApiEmpTab(id:number): Observable<any>{
    return this.http.delete<MVCWebApi>(endpoint +  'deletewithid/'+id);
  }

  getWebApiEmpTabWithId(id:number): Observable<any>{
    return this.http.get<MVCWebApi>(endpoint +  'getdetailswithid/'+id);
  }

    updateWebApiEmpTab(id:number,emp:MVCWebApi): Observable<any>{
      return this.http.put<MVCWebApi>(endpoint + 'editwithid/' +id,emp);
    }

  
}
