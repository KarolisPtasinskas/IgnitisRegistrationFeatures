import { Component, OnInit } from '@angular/core';
import { RegistrationFormDto } from '../../../../models/RegistrationFormDto';
import { ControllersService } from '../../services/controllers.service';

@Component({
  selector: 'app-form-list',
  templateUrl: './form-list.component.html',
  styleUrls: ['./form-list.component.css']
})
export class FormListComponent implements OnInit {
  forms: RegistrationFormDto[] = [];


  constructor(private controllers: ControllersService) { }

  ngOnInit() {
    this.controllers.getForms().subscribe(response => {
      this.forms = response;
    });
  }

}
