import { Component, OnInit } from '@angular/core';
import { Order } from '../../shared/orders'

@Component({
  selector: 'app-section-orders',
  templateUrl: './section-orders.component.html',
  styleUrls: ['./section-orders.component.css']
})
export class SectionOrdersComponent implements OnInit {

  constructor() {}

  orders: Order[] = [
    {
      id: 1, 
      customer: {
        id: 1, 
        name: 'asdf', 
        state: 'CO', 
        email: 'sss@sss.com'
      }, 
      total: 10, 
      placed: new Date('2019-06-03'), 
      fulfilled: new Date('2019-07-03'), 
      status: 'Completed'
    },
    {
      id: 2, 
      customer: {
        id: 1, 
        name: 'asdf', 
        state: 'CO', 
        email: 'sss@sss.com'
      }, 
      total: 10, 
      placed: new Date('2019-06-03'), 
      fulfilled: new Date('2019-07-03'), 
      status: 'Completed'
    },
    {
      id: 3, 
      customer: {
        id: 1, 
        name: 'asdf', 
        state: 'CO', 
        email: 'sss@sss.com'
      }, 
      total: 10, 
      placed: new Date('2019, 12, 1'), 
      fulfilled: new Date('2019, 12, 3'), 
      status: 'Completed'
    },
    {
      id: 4, 
      customer: {
        id: 1, 
        name: 'asdf', 
        state: 'CO', 
        email: 'sss@sss.com'
      }, 
      total: 10, 
      placed: new Date('2019-06-03'), 
      fulfilled: new Date('2019-07-03'), 
      status: 'Completed'
    }
  ];

  ngOnInit() {
  }

}
