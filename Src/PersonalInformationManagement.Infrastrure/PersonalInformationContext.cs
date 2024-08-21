using Microsoft.EntityFrameworkCore;
using PersonalInformationManagement.Domain.ResumeAgg;
using PersonalInformationManagement.Infrastrure.ResumeInfra;

namespace PersonalInformationManagement.Infrastrure
{
	public class PersonalInformationContext : DbContext
	{
		public PersonalInformationContext(DbContextOptions<PersonalInformationContext> options) : base(options)
		{
		}


		#region Table in Sql
		public DbSet<Resume> Resumes { get; set; }
		public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
		#endregion

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var assamble = typeof(ResumeConfiguration).Assembly;
			modelBuilder.ApplyConfigurationsFromAssembly(assamble);

			base.OnModelCreating(modelBuilder);
		}



	}
}
