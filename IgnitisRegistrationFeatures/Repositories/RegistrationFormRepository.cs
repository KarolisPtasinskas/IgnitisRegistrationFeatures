using IgnitisRegistrationFeatures.Data;
using IgnitisRegistrationFeatures.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IgnitisRegistrationFeatures.Repositories
{
    public class RegistrationFormRepository : IRegistrationFormRepository<RegistrationForm>
    {
        private readonly RegistrationFormContext _registrationFormContext;

        public RegistrationFormRepository(RegistrationFormContext registrationFormContext)
        {
            _registrationFormContext = registrationFormContext;
        }
        public async Task<List<RegistrationForm>> GetAllAsync()
        {
            return await _registrationFormContext.RegistrationForms.ToListAsync();
        }

        public async Task<RegistrationForm> GetByIdAsync(int id)
        {
            return await _registrationFormContext.RegistrationForms
                .Include(q => q.Questions)
                .ThenInclude(a => a.Answers)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
