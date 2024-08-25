using _0_FrameWork.FW.Infrastrure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceHost.Pages.Resumes.Panel.Education
{
    [ResumeRealUser]
    public class IndexModel : PageModel
    {
        private readonly IEducationApplication _application;
        private readonly IResumeSession _resumeSession;
        public long resumeId;
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
            var res = await _application.AddAsync(request);
            return new JsonResult(res);
        }

        public IActionResult OnGetEdit(long educationId)
        {
            var res = _application.GetDetailAsync(educationId).Result;
            return Partial("./Edit",res);
        }

        public async Task<JsonResult> OnPostEditAsync(Education_Edit_Request request)
        {
            var res = await _application.EditAsync(request);
            return new JsonResult(res);
        }

    }
}
