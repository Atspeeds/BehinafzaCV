using PersonalInformationManagement.Application.Contract.ResumeCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application
{
    public partial class ResumeApplication
	{
		public Task<List<Resume_GetAll_Response>> GetAllByAsync(Resume_GetUserId_Request request)
		{
			return _resumerepository.GetAllAsync(request.UserId);
		}

    }
}
