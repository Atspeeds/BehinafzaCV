using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace PersonalInformationManagement.Application.ExperienceApp
{
    public partial class ExperienceApplication : IExperienceApplication
    {
        private readonly IExperienceRepository _experiencerepository;

        public ExperienceApplication(IExperienceRepository experienceRepository)
        {
            _experiencerepository = experienceRepository;
        }

        
    }
}
