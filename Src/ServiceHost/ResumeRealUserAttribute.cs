using Microsoft.AspNetCore.Mvc;
using System;

namespace ServiceHost
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ResumeRealUserAttribute : TypeFilterAttribute
    {
        public ResumeRealUserAttribute() : base(typeof(ResumeRealUserFilter))
        {
        }
    }
}
