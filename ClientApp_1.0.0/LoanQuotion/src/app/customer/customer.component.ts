import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { CustomerServiceService } from '../Service/customer-service.service';
import { ICustomer } from '../Interface/ICustomer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})
export class CustomerComponent implements OnInit {

  customers: ICustomer[] = [];
  pushCustomers: any;
  constructor(private customerService: CustomerServiceService) { }

  ngOnInit(): void {

  }

  addCusomter(id_number: string, first_name: string, last_name: string,
    date_of_birth: string, contact_number: string, income: string, job: string, employer: string
  ):
    void {this.customerService.addCustomer(
      { id_number,first_name,last_name,date_of_birth,contact_number,income,job,employer } as ICustomer)
      .subscribe(customers => { this.customers.push(customers) });


  }




}
