using _0_FrameWork.FW.Infrastrure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon.ViewModel.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceHost.Pages.Resumes.Panel.Experience
{
    [ResumeRealUser]
    public class IndexModel : PageModel
    {

        private readonly IExperienceApplication _application;
        private readonly IResumeSession _resumeSession;
        public long resumeId;
        public IndexModel(IExperienceApplication application, IResumeSession resumeSession)
        {
            _application = application;
            _resumeSession = resumeSession;
            resumeId = _resumeSession.GetResumeId(SessionName.ResumeIdSession);
        }

        public List<Experience_GetAll_Request> Experiences;
        public Experience_Search_Request request;

        public void OnGet(Experience_Search_Request request)
        {
            request.ResumeId = resumeId;
            Experiences = _application.SearchAsync(request).Result;
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public async Task<JsonResult> OnPostCreateAsync(Experience_Add_Request request)
        {
            request.ResumeId = resumeId;
            var res = await _application.AddAsync(request);
            return new JsonResult(res);
        }

        public IActionResult OnGetEdit(long experienceId)
        {
            var res = _application.GetDetailAsync(experienceId).Result;
            return Partial("./Edit", res);
        }

        public async Task<JsonResult> OnPostEditAsync(Experience_Edit_Request request)
        {
            var res = await _application.EditAsync(request);
            return new JsonResult(res);
        }


    }
}
