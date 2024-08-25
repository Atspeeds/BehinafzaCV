using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalInformationManagement.Application;
using PersonalInformationManagement.Application.Contract.EducationCon;
using PersonalInformationManagement.Application.Contract.ExperienceCon;
using PersonalInformationManagement.Application.Contract.ResumeCon;
using PersonalInformationManagement.Application.Contract.SkillCon;
using PersonalInformationManagement.Application.EducationApp;
using PersonalInformationManagement.Application.ExperienceApp;
using PersonalInformationManagement.Domain.ResumeAgg.RepositoryService;
using PersonalInformationManagement.Infrastrure.ResumeInfra;


namespace PersonalInformationManagement.Infrastrure.Bootstrapper
{
    public class PersonalInformationConfigBootstrapper
	{
		public static void Configure(IServiceCollection services, string connection)
		{

            services.AddTransient<IResumeApplication, ResumeApplication>();
            services.AddTransient<IResumeRepository, ResumeRepository>();
		
			services.AddTransient<ISkillApplication, SkillApplication>();
			services.AddTransient<ISkillRepository, SkillRepository>();

            services.AddTransient<IExperienceApplication, ExperienceApplication>();
            services.AddTransient<IExperienceRepository, ExperienceRepository>();

            services.AddTransient<IEducationApplication, EducationApplication>();
            services.AddTransient<IEducationRepository, EducationRepository>();
 

            //Used Sql Server
            services.AddDbContext<PersonalInformationContext>(options => options.UseSqlServer(connection));
		}
	}
}
