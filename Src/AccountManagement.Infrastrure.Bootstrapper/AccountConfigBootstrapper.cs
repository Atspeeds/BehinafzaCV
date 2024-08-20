using _0_FrameWork.FW.Application;
using AccountManagement.Application;
using AccountManagement.Application.UserApp;
using AccountManagement.Domain.UserAgg;
using AccountManagement.Infrastrure.UserInfra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AccountManagement.Infrastrure
{
    public class AccountConfigBootstrapper
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserApplication, UserApplication>();

            services.AddTransient<IPasswordHasher, PasswordHasher>();


            //Used Sql Server
            services.AddDbContext<AccountContext>(options => options.UseSqlServer(connection));
        }
    }
}
