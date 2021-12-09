import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { QuestionDto } from '../../../models/QuestionDto';
import { RegistrationFormDto } from '../../../models/RegistrationFormDto';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};

@Injectable({
  providedIn: 'root'
})
export class ControllersService {
  private formsController = 'registrationforms';
  private questionsController = 'questions';

  constructor(private http: HttpClient) { }

  getForms(): Observable<RegistrationFormDto[]> {
    return this.http.get<RegistrationFormDto[]>(this.formsController, httpOptions);
  }

  getFormById(id: string): Observable<RegistrationFormDto> {
    return this.http.get<RegistrationFormDto>(this.formsController + `/${id}`);
  }

  updateQuestions(questions: QuestionDto[]): Observable<any> {
    return this.http.put<any>(this.questionsController, questions);
  }

}
