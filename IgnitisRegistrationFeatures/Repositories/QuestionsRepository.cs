using IgnitisRegistrationFeatures.Data;
using IgnitisRegistrationFeatures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IgnitisRegistrationFeatures.Repositories
{
    public class QuestionsRepository : IQuestionsRepository<Question>
    {
        private readonly RegistrationFormContext _registrationFormContext;

        public QuestionsRepository(RegistrationFormContext registrationFormContext)
        {
            _registrationFormContext = registrationFormContext;
        }

        public async Task UpdateAsync(List<Question> questions)
        {
            _registrationFormContext.Questions.UpdateRange(questions);
            await _registrationFormContext.SaveChangesAsync();
        }
    }
}
