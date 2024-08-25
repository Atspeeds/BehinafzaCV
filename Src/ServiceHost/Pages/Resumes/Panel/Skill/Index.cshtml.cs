using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System.Collections.Generic;
using PersonalInformationManagement.Application.Contract.SkillCon;
using _0_FrameWork.FW.Infrastrure;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace ServiceHost.Pages.Resumes.Panel.Skill
{
    [ResumeRealUser]
    public class IndexModel : PageModel
    {
        private readonly ISkillApplication _application;
        private readonly IResumeSession _resumeSession;
        private long resumeId;
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

    }
}
