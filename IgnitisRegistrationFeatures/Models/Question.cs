using System.Collections.Generic;

namespace IgnitisRegistrationFeatures.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationFormId { get; set; }
        public List<Answer> Answers { get; set; }
        public int? SelectedAnswerId { get; set; }
    }
}
