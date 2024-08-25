using _0_FrameWork.FW.Application;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace PersonalInformationManagement.Application
{
    public partial class ResumeApplication : IResumeApplication
    {
        private readonly IResumeRepository _resumerepository;
        private readonly IAuthHelper _authHelper;
        public ResumeApplication(IResumeRepository repository, IAuthHelper authHelper)
        {
            _resumerepository = repository;
            _authHelper = authHelper;
        }

     
    }
}
