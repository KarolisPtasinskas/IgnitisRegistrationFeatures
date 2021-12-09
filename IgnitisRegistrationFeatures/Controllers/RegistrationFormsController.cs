using IgnitisRegistrationFeatures.Models;
using IgnitisRegistrationFeatures.Models.Dto;
using IgnitisRegistrationFeatures.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeatures.Controllers
{
    [Route("[controller]")]
    public class RegistrationFormsController : Controller
    {
        private readonly RegistrationFormService _registrationFormService;

        public RegistrationFormsController(RegistrationFormService registrationFormService)
        {
            _registrationFormService = registrationFormService;
        }

        [HttpGet]
        public async Task<List<RegistrationFormDto>> GetAll()
        {
            var registrationFormsDto = await _registrationFormService.GetAllAsync();

            return registrationFormsDto;
        }


        [HttpGet("{id}")]
        public async Task<RegistrationFormDto> GetById(int id)
        {
            var registrationForm = await _registrationFormService.GetByIdAsync(id);

            return registrationForm;
        }
    }
}
