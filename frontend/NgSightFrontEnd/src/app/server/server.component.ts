import { Component, OnInit, Input } from '@angular/core';
import { Server } from '../shared/server'

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent implements OnInit {

  constructor() { }

  color: string;
  buttonText: string;

  @Input() serverInput: Server;

  ngOnInit() {
    this.setServerAction(this.serverInput.isOnline);
  }

  setServerAction(isOnline: boolean) {
    if(isOnline) {
      this.serverInput.isOnline = true;
      this.color = '#66bb6a';
      this.buttonText = 'Shut Down';
      
    } else {
      this.serverInput.isOnline = false;
      this.color = '#FF6b6b';
      this.buttonText = 'Start';
    }
  }

  toggleStatus(onlineStatus: boolean) {
    console.log(this.serverInput.name, ': ', onlineStatus);
    this.setServerAction(!onlineStatus);
  }

}
