using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Request;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.Contract.ResumeCon
{
    public interface IResumeApplication
	{
		Task<bool> AddAsync(Resume_Add_Request request);
		Task<List<Resume_GetAll_Response>> GetAllByAsync(Resume_GetUserId_Request request);

	}
}
