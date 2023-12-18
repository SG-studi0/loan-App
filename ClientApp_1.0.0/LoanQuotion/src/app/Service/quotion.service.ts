import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, Observable, tap, throwError } from 'rxjs';
import { IQuotion } from '../Interface/IQuotion';


@Injectable({
  providedIn: 'root'
})
export class QuotionService {

  private apiUrl = "https://localhost:7154/api";
  constructor(private http : HttpClient) { }

getQuotion(): Observable<IQuotion[]>{
  return this.http.get<IQuotion[]>(`${this.apiUrl}/Loan`)
 
}

}
