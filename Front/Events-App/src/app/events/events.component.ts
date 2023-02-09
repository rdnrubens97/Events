import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.GetEvents();
  }

  public GetEvents(): void {
    this.http.get('https://localhost:7047/api/Events').subscribe(response => this.events = response,
    error => console.log(error));
  }
}
