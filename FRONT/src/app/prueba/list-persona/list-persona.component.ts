import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'kt-list-persona',
  templateUrl: './list-persona.component.html',
  styleUrls: ['./list-persona.component.scss']
})
export class ListPersonaComponent implements OnInit {

  dataSource
  datos =[{nombre:"Jhon",apellido:"Romero"},
  {nombre:"Carlos",apellido:"Vera"},
  {nombre:"Steph",apellido:"Neighbourhood"}]
  constructor() { }

  ngOnInit() {
    this.dataSource = new MatTableDataSource<any>(this.datos);

  }

}
