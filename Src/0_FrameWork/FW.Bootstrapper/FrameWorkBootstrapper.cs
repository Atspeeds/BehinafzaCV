using _0_FrameWork.FW.Application;
using Microsoft.Extensions.DependencyInjection;

namespace _0_FrameWork.FW.Bootstrapper
{
    public class FrameWorkBootstrapper
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IAuthHelper, AuthHelper>();
            services.AddTransient<IPasswordHasher, PasswordHasher>();

        }
    }
}
