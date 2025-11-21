import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-customers',
  standalone: false,
  templateUrl: './customers.html',
  styleUrl: './customers.css',
})

export class Customers implements OnInit {
  public customers: Customers[] = [];
  constructor(private http: HttpClient) { }
  ngOnInit() {
    this.getCustomers();
  }
  getCustomers() {
    this.http.get<Customers[]>("/api/customer/list").subscribe(
      (result) => {
        this.customers = result;
      },
      (error) => {
        console.error(error);
      }

    );
  }

}
export interface Customers {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  city: string;
  balance: number;

}
