using _0_FrameWork.FW.Application;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
{
    public partial class ResumeApplication : IResumeApplication, ISkillApplication
    {
        private readonly IResumeRepository _resumerepository;
        private readonly ISkillRepository _skillRepository;
        private readonly IAuthHelper _authHelper;
        public ResumeApplication(IResumeRepository repository, ISkillRepository skillRepository, IAuthHelper authHelper)
        {
            _resumerepository = repository;
            _authHelper = authHelper;
            _skillRepository=skillRepository;
        }

     
    }
}
