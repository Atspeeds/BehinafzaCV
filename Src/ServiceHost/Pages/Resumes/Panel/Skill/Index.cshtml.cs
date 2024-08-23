using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Request;
using System.Threading.Tasks;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using System.Collections.Generic;
using PersonalInformationManagement.Application.Contract.ResumeCon.ViewModel.Response;
using Microsoft.AspNetCore.Http;
using System;

namespace ServiceHost.Pages.Resumes.Panel.Skill
{
    public class IndexModel : PageModel
    {
        private readonly ISkillApplication _application;

        public IndexModel(ISkillApplication application)
        {
            _application = application;
        }

        public List<Skill_GetAll_Response> Skills;

        public void OnGet(long id)
        {
            HttpContext.Session.SetString("ResumeID", id.ToString());
            Skills = _application.GetAllAsync(id).Result;
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public async Task<JsonResult> OnPostCreateAsync(Skill_Add_Request request)
        {
            request.ResumeId = Convert.ToInt64(HttpContext.Session.GetString("ResumeID"));
            var res = await _application.AddAsync(request);
            return new JsonResult(res);
        }

    }
}
