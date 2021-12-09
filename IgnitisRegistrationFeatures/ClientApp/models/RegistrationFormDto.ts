import { QuestionDto } from "./QuestionDto";

export interface RegistrationFormDto {
  id: number;
  name: string;
  questions: QuestionDto[];
}
