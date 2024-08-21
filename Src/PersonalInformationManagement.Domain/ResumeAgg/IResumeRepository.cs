using _0_FrameWork.FW.Domain;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Domain.ResumeAgg
{
	public interface IResumeRepository : IRepositoryBase<long, Resume>
	{
		Task<List<Resume_GetAll_Response>> GetByAsync(long userId);
	}
}
