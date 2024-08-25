using _0_FrameWork.FW.Domain;
using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon.ViewModel.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Domain.ResumeAgg.RepositoryService
{
    public interface IExperienceRepository : IRepositoryBase<long, Experience>
    {
        Task<List<Experience_GetAll_Request>> SearchAsync(Experience_Search_Request request);
        Task<Experience_Edit_Request> GetDetailAsync(long id);
    }
}
