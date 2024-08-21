using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalInformationManagement.Application;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Domain.ResumeAgg;
using PersonalInformationManagement.Infrastrure.ResumeInfra;


namespace PersonalInformationManagement.Infrastrure.Bootstrapper
{
	public class PersonalInformationConfigBootstrapper
	{
		public static void Configure(IServiceCollection services, string connection)
		{
			services.AddTransient<IResumeRepository, ResumeRepository>();
			services.AddTransient<IResumeApplication, ResumeApplication>();

			//Used Sql Server
			services.AddDbContext<PersonalInformationContext>(options => options.UseSqlServer(connection));
		}
	}
}
