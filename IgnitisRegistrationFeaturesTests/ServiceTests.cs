using AutoFixture;
using AutoMapper;
using FluentAssertions;
using IgnitisRegistrationFeatures.AutoMapper;
using IgnitisRegistrationFeatures.Models;
using IgnitisRegistrationFeatures.Models.Dto;
using IgnitisRegistrationFeatures.Repositories;
using IgnitisRegistrationFeatures.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgnitisRegistrationFeaturesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task RegistrationFormService_GetAllAsync_Returns_MappedObjects()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfiles>());
            var mapper = new Mapper(config);

            var fixture = new Fixture();
            var regForms = fixture.CreateMany<RegistrationForm>().ToList();
            var regFormsDto = mapper.Map<List<RegistrationFormDto>>(regForms);

            var mockRegFormsRepository = new Mock<IRegistrationFormRepository<RegistrationForm>>();
            mockRegFormsRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(regForms);

            var registrationFormService = new RegistrationFormService(mockRegFormsRepository.Object, mapper);

            var result = await registrationFormService.GetAllAsync();

            result.Should().BeEquivalentTo(regFormsDto);
        }

        [Test]
        public async Task RegistrationFormService_GetByIdAsync_Returns_MappedObject()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfiles>());
            var mapper = new Mapper(config);

            var fixture = new Fixture();
            var regForm = fixture.Create<RegistrationForm>();
            var regFormDto = mapper.Map<RegistrationFormDto>(regForm);

            var mockRegFormsRepository = new Mock<IRegistrationFormRepository<RegistrationForm>>();
            mockRegFormsRepository.Setup(r => r.GetByIdAsync(regForm.Id)).ReturnsAsync(regForm);

            var registrationFormService = new RegistrationFormService(mockRegFormsRepository.Object, mapper);

            var result = await registrationFormService.GetByIdAsync(regForm.Id);

            result.Should().BeEquivalentTo(regFormDto);
        }
    }
}