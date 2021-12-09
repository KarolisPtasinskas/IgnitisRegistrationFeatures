using System.Collections.Generic;

namespace IgnitisRegistrationFeatures.Models.Dto
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationFormId { get; set; }
        public List<AnswerDto> Answers { get; set; }
        public int? SelectedAnswerId { get; set; }
    }
}
