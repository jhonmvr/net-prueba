import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-modal-historial',
  templateUrl: './modal-historial.component.html',
  styleUrls: ['./modal-historial.component.css']
})
export class ModalHistorialComponent implements OnInit {

  iconoUrl="";
  constructor() {
    this.iconoUrl=environment.rootContext;
   }

  ngOnInit() {
  }

}
