using IgnitisRegistrationFeatures.Models;
using IgnitisRegistrationFeatures.Models.Dto;
using IgnitisRegistrationFeatures.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeatures.Controllers
{
    [Route("[controller]")]
    public class QuestionsController : Controller
    {
        private readonly QuestionsService _questionsService;

        public QuestionsController(QuestionsService questionsService)
        {
            _questionsService = questionsService;
        }

        [HttpPut]
        public async Task Update([FromBody] List<QuestionDto> questions)
        {
            await _questionsService.UpdateAsync(questions);
        }
    }
}
