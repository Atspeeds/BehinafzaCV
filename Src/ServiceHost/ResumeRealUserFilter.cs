using _0_FrameWork.FW.Application;
using _0_FrameWork.FW.Infrastrure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;

namespace ServiceHost
{
    public class ResumeRealUserFilter : IPageFilter
    {
        private readonly IResumeRepository _repository;
        private readonly IAuthHelper _authHelper;
        private readonly IResumeSession _resumeSession;

        public ResumeRealUserFilter(IResumeRepository repository, IAuthHelper authHelper, IResumeSession resumeSession)
        {
            _repository = repository;
            _authHelper = authHelper;
            _resumeSession = resumeSession;
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {


            var userId = _authHelper.GetUserId();

            if (context.RouteData.Values.TryGetValue("id", out var idValue) &&
                long.TryParse(idValue.ToString(), out long id))
            {
                _resumeSession.SetResumeId(id);

                if (!_repository.ExistsAysenc(x => x.KeyId == id && x.UserId == userId).Result)
                {
                    context.Result = new RedirectResult("/NotFound");
                }
            }
            else
            {
                context.Result = new RedirectResult("/NotFound");
            }


        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }
    }
}
