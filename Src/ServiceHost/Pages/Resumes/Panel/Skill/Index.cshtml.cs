using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System.Collections.Generic;
using PersonalInformationManagement.Application.Contract.SkillCon;
using _0_FrameWork.FW.Infrastrure;
using Microsoft.AspNetCore.Authorization;

namespace ServiceHost.Pages.Resumes.Panel.Skill
{
    [Authorize]
    [ResumeRealUser]
    public class IndexModel : PageModel
    {
        private readonly ISkillApplication _application;
        private readonly IResumeSession _resumeSession;
        public long resumeId;
        public IndexModel(ISkillApplication application,IResumeSession resumeSession)
        {
            _application = application;
            _resumeSession = resumeSession;
            resumeId = _resumeSession.GetResumeId(SessionName.ResumeIdSession);

        }

        public List<Skill_GetAll_Response> Skills;

        
        public void OnGet()
        {
            Skills = _application.GetAllAsync(resumeId).Result;
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public async Task<JsonResult> OnPostCreateAsync(Skill_Add_Request request)
        {
            request.ResumeId = resumeId;
            var res = await _application.AddAsync(request);
            return new JsonResult(res);
        }
        public IActionResult OnGetEdit(long skillId)
        {
            var res = _application.GetDetailAsync(skillId).Result;
            return Partial("./Edit", res);
        }

        public async Task<JsonResult> OnPostEditAsync(Skill_Edit_Request request)
        {
            var res = await _application.EditAsync(request);
            return new JsonResult(res);
        }
    }
}
