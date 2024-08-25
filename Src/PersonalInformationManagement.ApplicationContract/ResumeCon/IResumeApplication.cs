using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.Contract.ResumeCon
{
    public interface IResumeApplication 
    {
        Task<bool> AddAsync(Resume_Add_Request request);
        Task<List<Resume_GetAll_Response>> GetAllByAsync(Resume_GetUserId_Request request);
        Task<bool> EditAsync(Resume_Edit_Request request);
        Task<Resume_Edit_Request> GetDetailAsync(long id);
        Task<ResumeOutPut_GetAll_Response> GetResumeOutPut(long id);
        Task<bool> DeleteAsync(long id);
    }
}
