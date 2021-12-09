using System.Collections.Generic;

namespace IgnitisRegistrationFeatures.Models
{
    public class RegistrationForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
