using IgnitisRegistrationFeatures.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeatures.Services
{
    public interface IRegistrationFormService
    {
        Task<List<RegistrationFormDto>> GetAllAsync();
        Task<RegistrationFormDto> GetByIdAsync(int id);
    }
}