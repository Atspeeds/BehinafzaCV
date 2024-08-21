using _0_FrameWork.FW.Application;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace PersonalInformationManagement.Application
{
	public partial class ResumeApplication : IResumeApplication
    {
        private readonly IResumeRepository _repository;
        private readonly IAuthHelper _authHelper;
        public ResumeApplication(IResumeRepository repository, IAuthHelper authHelper)
        {
            _repository = repository;
            _authHelper = authHelper;
        }

		
	}
}
