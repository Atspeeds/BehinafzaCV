using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace PersonalInformationManagement.Application.EducationApp
{
    public partial class EducationApplication : IEducationApplication
    {
        private readonly IEducationRepository _educationRepository;

        public EducationApplication(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

      
    }
}
