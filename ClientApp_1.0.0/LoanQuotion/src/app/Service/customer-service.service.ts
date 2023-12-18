import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, Observable, tap, throwError } from 'rxjs';
import { ICustomer } from '../Interface/ICustomer';


@Injectable({
  providedIn: 'root'
})
export class CustomerServiceService {

  private apiUrl = "https://localhost:7154/api";

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  
  addCustomer(customer : ICustomer): Observable<ICustomer> {
    return this.http.post<ICustomer>(`${this.apiUrl}/Customer`, customer, this.httpOptions)
   
  }
  
}
