using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;

namespace ServiceHost.Pages.Resumes.Resume
{
    [Authorize]
    [ResumeRealUser]
    public class BehinResumeOutputModel : PageModel
    {
        private readonly IResumeApplication _application;

        public BehinResumeOutputModel(IResumeApplication application)
        {
            _application = application;
        }

        public ResumeOutPut_GetAll_Response Resume;
        public string Title;
        public void OnGet(long id)
        {
            Resume = _application.GetResumeOutPut(id).Result;
            Title = _application.GetDetailAsync(id).Result.Summary;
        }
    }
}
