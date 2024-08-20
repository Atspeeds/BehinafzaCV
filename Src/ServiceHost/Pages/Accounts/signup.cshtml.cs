using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using AccountManagement.Application;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Pages.Accounts
{
	public class signupModel : PageModel
	{

		public User_Register_Request request;

		private readonly IUserApplication _application;

		public signupModel(IUserApplication application)
		{
			_application = application;
		}

		public void OnGet()
        {
        }

		public async Task<IActionResult> OnPostAsync(User_Register_Request request)
		{
			await _application.RegisterAsync(request);
			return RedirectToPage("Index");
		}

	}
}
