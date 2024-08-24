using _0_FrameWork.FW.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace ServiceHost
{
    public class ResumeRealUser : IPageFilter
    {
        private readonly IResumeRepository _repository;
        private readonly IAuthHelper _authHelper;

        public ResumeRealUser(IResumeRepository repository, IAuthHelper authHelper)
        {
            _repository = repository;
            _authHelper = authHelper;
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            var UserId = _authHelper.GetUserId();
            var id =long.Parse(context.RouteData.Values["id"].ToString());
            if (!_repository.ExistsAysenc(x => x.KeyId == id && x.UserId == UserId).Result)
            {
				context.Result = new RedirectResult("/NotFound");
			}
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            
        }
    }
}
