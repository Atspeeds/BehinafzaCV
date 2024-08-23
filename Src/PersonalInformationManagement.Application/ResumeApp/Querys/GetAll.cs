using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Request;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
{
	public partial class ResumeApplication
	{
		public Task<List<Resume_GetAll_Response>> GetAllByAsync(Resume_GetUserId_Request request)
		{
			return _resumerepository.GetByAsync(request.UserId);
		}

        public Task<List<Skill_GetAll_Response>> GetAllAsync(long resumeId)
        {
			return _skillRepository.GetByResume(resumeId);
        }
    }
}
