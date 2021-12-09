using IgnitisRegistrationFeatures.Models;
using IgnitisRegistrationFeatures.Repositories;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AutoMapper;
using IgnitisRegistrationFeatures.Models.Dto;

namespace IgnitisRegistrationFeatures.Services
{
    public class RegistrationFormService : IRegistrationFormService
    {
        private readonly IRegistrationFormRepository<RegistrationForm> _registrationFormRepository;
        private readonly IMapper _mapper;

        public RegistrationFormService(IRegistrationFormRepository<RegistrationForm> registrationFormRepository, IMapper mapper)
        {
            _registrationFormRepository = registrationFormRepository;
            _mapper = mapper;
        }

        public async Task<List<RegistrationFormDto>> GetAllAsync()
        {
            var registrationForms = await _registrationFormRepository.GetAllAsync();
            return _mapper.Map<List<RegistrationFormDto>>(registrationForms);
        }

        public async Task<RegistrationFormDto> GetByIdAsync(int id)
        {
            var registrationForm = await _registrationFormRepository.GetByIdAsync(id);

            return _mapper.Map<RegistrationFormDto>(registrationForm);
        }
    }
}
