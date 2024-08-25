using _0_FrameWork.FW.Domain;
using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon.ViewModel.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Domain.ResumeAgg.RepositoryService
{
    public interface IEducationRepository : IRepositoryBase<long, Education>
    {
        Task<List<Education_GetAll_Response>> SearchAsync(Education_Search_Request request);
    }
}
