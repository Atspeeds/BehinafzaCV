using PersonalInformationManagement.Application.Contract.ResumeCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalInformationManagement.Application.ResumeApp
{
    public partial class ResumeApplication
    {
        public Task<List<Resume_GetAll_Response>> GetAllByAsync(Resume_GetUserId_Request request)
        {
            return _resumerepository.GetAllAsync(request.UserId);
        }

        public Task<Resume_Edit_Request> GetDetailAsync(long id)
        {
            return _resumerepository.GetDetailAsync(id);
        }

    }
}
