using _0_FrameWork.FW.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceHost.Pages.Resumes.Resume
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public List<Resume_GetAll_Response> Resumes;

        private readonly IResumeApplication _application;
        private readonly IAuthHelper _authHelper;

        public IndexModel(IResumeApplication application, IAuthHelper authHelper)
        {
            _application = application;
            _authHelper = authHelper;
        }

        public async Task OnGetAsync()
        {
            var userId = _authHelper.GetUserId();
            Resumes = await _application.GetAllByAsync(new Resume_GetUserId_Request(userId));
        }

        public async Task<JsonResult> OnPostCreateAsync(Resume_Add_Request request)
        {
            var res = await _application.AddAsync(request);
            return new JsonResult(res);
        }

        public IActionResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public IActionResult OnGetEdit(long resumeId)
        {
            var res = _application.GetDetailAsync(resumeId).Result;
            return Partial("./Edit", res);
        }

        public async Task<JsonResult> OnPostEditAsync(Resume_Edit_Request request)
        {
            var res = await _application.EditAsync(request);
            return new JsonResult(res);
        }

        public IActionResult OnGetDelete(long id)
        {
            var res = _application.GetDetailAsync(id).Result;
            return Partial("./Delete", res);
        }

        public async Task<JsonResult> OnPostDeleteAsync(long id)
        {
            var res = await _application.DeleteAsync(id);
            return new JsonResult(res);
        }
    }
}
