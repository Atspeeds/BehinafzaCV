using Microsoft.AspNetCore.Http;
using System;

namespace _0_FrameWork.FW.Infrastrure
{
    public class ResumeSession : IResumeSession
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public ResumeSession(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public long GetResumeId(string key)
        {
           return Convert.ToInt64(_contextAccessor.HttpContext.Session.GetString("ResumeID"));
        }

        public void SetResumeId(long id)
        {
           _contextAccessor.HttpContext.Session.SetString("ResumeID", id.ToString());
        }
    }
}
