using IgnitisRegistrationFeatures.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeatures.Services
{
    public interface IQuestionsService
    {
        Task UpdateAsync(List<QuestionDto> questions);
    }
}