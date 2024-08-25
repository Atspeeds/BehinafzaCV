using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using PersonalInformationManagement.Domain.ResumeAgg;
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

        public async Task<ResumeOutPut_GetAll_Response> GetResumeOutPut(long id)
        {
            var result = new ResumeOutPut_GetAll_Response()
            {
                Skills = _skillRepository?.GetByResume(id).Result,
                Educations = _educationRepository?.GetByResumeAsync(id).Result,
                Experiences = _experienceRepository?.GetByResumeAsync(id).Result,
            };

            return await Task.FromResult(result);

        }

    }
}
