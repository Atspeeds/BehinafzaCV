using _0_FrameWork.FW.Infrastrure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInformationManagement.Application.Contract.EducationCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceHost.Pages.Resumes.Panel.Education
{
    [ResumeRealUser]
    public class IndexModel : PageModel
    {
        private readonly IEducationApplication _application;
        private readonly IResumeSession _resumeSession;
        private long resumeId;
        public IndexModel(IEducationApplication application, IResumeSession resumeSession)
        {
            _application = application;
            _resumeSession = resumeSession;
            resumeId = _resumeSession.GetResumeId(SessionName.ResumeIdSession);
        }

        public List<Education_GetAll_Response> Educations;
        public Education_Search_Request request;

        public void OnGet(Education_Search_Request request)
        {
            request.ResumeId = resumeId;
            Educations = _application.SearchAsync(request).Result;
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public async Task<JsonResult> OnPostCreateAsync(Education_Add_Request request)
        {
            request.ResumeId = resumeId;
            var res = await _application.AddAsync(request);
            return new JsonResult(res);
        }
    }
}
