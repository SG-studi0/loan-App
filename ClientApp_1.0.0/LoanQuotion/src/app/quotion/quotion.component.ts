import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { QuotionService } from '../Service/quotion.service';
import { IQuotion } from '../Interface/IQuotion';

@Component({
  selector: 'app-quotion',
  templateUrl: './quotion.component.html',
  styleUrls: ['./quotion.component.scss']
})
export class QuotionComponent implements OnInit {

  
  loans: any;
  
  constructor(private quotionSerivce : QuotionService ) { }

  ngOnInit(): void {
    this.getLoan();
  }

  getLoan(): void {
    this.quotionSerivce.getQuotion()
    .subscribe(loans => this.loans = loans)
  }
 
}
