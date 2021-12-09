using System.Collections.Generic;

namespace IgnitisRegistrationFeatures.Models.Dto
{
    public class RegistrationFormDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<QuestionDto> Questions { get; set; }
    }
}
