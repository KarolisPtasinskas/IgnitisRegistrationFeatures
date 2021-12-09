import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { QuestionDto } from '../../../../models/QuestionDto';
import { RegistrationFormDto } from '../../../../models/RegistrationFormDto';
import { ControllersService } from '../../services/controllers.service';

@Component({
  selector: 'app-edit-form',
  templateUrl: './edit-form.component.html',
  styleUrls: ['./edit-form.component.css']
})
export class EditFormComponent implements OnInit {
  id: string;
  form: RegistrationFormDto;
  questions: QuestionDto[] = [];

  selectDisabled: boolean = true;

  adjustBtnDisabled: boolean = false;
  saveBtnDisabled: boolean = true;
  cancelBtnDisabled: boolean = true;

  constructor(private activatedRoute: ActivatedRoute, private controllers: ControllersService) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(
      (param) => (this.id = param.get('id'))
    );

    if (this.id != null) {
      this.getQuestionsAndAnswers();
    }
  }

  getQuestionsAndAnswers() {
    this.controllers.getFormById(this.id).subscribe(response => {
      this.form = response;
      this.questions = this.form.questions.slice(0);
    })
  }

  onSelectChangeAnswer(optionId, value) {
    let questionIndex = this.questions.findIndex(q => q.id == optionId);
    this.questions[questionIndex].selectedAnswerId = parseInt(value);
  }

  adjustBtnClick() {
    this.toggleDisableItems();
    this.getQuestionsAndAnswers();
  }

  saveBtnClick() {
    this.controllers.updateQuestions(this.questions).subscribe(() => {
      this.toggleDisableItems();
    })
  }

  cancelBtnClick() {
    this.toggleDisableItems();
    this.ngOnInit();
  }

  toggleDisableItems() {
    this.saveBtnDisabled = !this.saveBtnDisabled;
    this.cancelBtnDisabled = !this.cancelBtnDisabled;
    this.adjustBtnDisabled = !this.adjustBtnDisabled;

    this.selectDisabled = !this.selectDisabled;
  }
}
