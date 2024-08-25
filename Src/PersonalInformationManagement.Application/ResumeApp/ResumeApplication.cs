using _0_FrameWork.FW.Application;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace PersonalInformationManagement.Application.ResumeApp
{
    public partial class ResumeApplication : IResumeApplication
    {
        private readonly IResumeRepository _resumerepository;
        private readonly ISkillRepository _skillRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly IEducationRepository _educationRepository;
        private readonly IAuthHelper _authHelper;
    

        public ResumeApplication(IResumeRepository repository, ISkillRepository skillRepository,
            IExperienceRepository experienceRepository, IEducationRepository educationRepository
            , IAuthHelper authHelper)
        {
            _resumerepository = repository;
            _skillRepository = skillRepository;
            _experienceRepository = experienceRepository;
            _educationRepository = educationRepository;
            _authHelper = authHelper;
        }

      
    }
}
