using _0_FrameWork.FW.Infrastrure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages.Resumes.Panel
{
    [Authorize]
    [ResumeRealUser]
    public class IndexModel : PageModel
    {
        public void OnGet(long id)
        {

        }

    }
}
