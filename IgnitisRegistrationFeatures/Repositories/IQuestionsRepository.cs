using IgnitisRegistrationFeatures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeatures.Repositories
{
    public interface IQuestionsRepository<T> where T : class
    {
        Task UpdateAsync(List<Question> question);
    }
}