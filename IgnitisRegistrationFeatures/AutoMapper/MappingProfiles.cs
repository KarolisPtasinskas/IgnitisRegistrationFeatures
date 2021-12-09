using AutoMapper;
using IgnitisRegistrationFeatures.Models;
using IgnitisRegistrationFeatures.Models.Dto;

namespace IgnitisRegistrationFeatures.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<RegistrationForm, RegistrationFormDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
        }
    }
}
