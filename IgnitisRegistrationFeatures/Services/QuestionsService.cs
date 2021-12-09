using AutoMapper;
using IgnitisRegistrationFeatures.Models;
using IgnitisRegistrationFeatures.Models.Dto;
using IgnitisRegistrationFeatures.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeatures.Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository<Question> _questionsRepository;
        private readonly IMapper _mapper;

        public QuestionsService(IQuestionsRepository<Question> questionsRepository, IMapper mapper)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
        }

        public async Task UpdateAsync(List<QuestionDto> questions)
        {
            var mappedQuestions = _mapper.Map<List<Question>>(questions);

            await _questionsRepository.UpdateAsync(mappedQuestions);
        }
    }
}
