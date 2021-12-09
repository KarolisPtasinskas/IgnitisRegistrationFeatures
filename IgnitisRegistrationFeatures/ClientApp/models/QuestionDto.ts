import { AnswerDto } from "./AnswerDto";

export interface QuestionDto {
  id: number;
  name: string;
  registrationFormId: number;
  answers: AnswerDto[];
  selectedAnswerId?: number;
}
