import { Component, Input, OnInit } from '@angular/core';
import { RegistrationFormDto } from '../../../../models/RegistrationFormDto';

@Component({
  selector: 'app-reg-form',
  templateUrl: './reg-form.component.html',
  styleUrls: ['./reg-form.component.css']
})
export class RegFormComponent implements OnInit {
  @Input() form: RegistrationFormDto;

  constructor() { }

  ngOnInit() {
  }

}
