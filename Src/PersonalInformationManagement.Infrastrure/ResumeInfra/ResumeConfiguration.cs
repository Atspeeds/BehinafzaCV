using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra
{
	public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
	{
		public void Configure(EntityTypeBuilder<Resume> builder)
		{

			builder.HasKey(x => x.KeyId);
			builder.Property(x => x.Summary).IsRequired();

		}
	}

	public class SkillConfiguration : IEntityTypeConfiguration<Skill>
	{
		public void Configure(EntityTypeBuilder<Skill> builder)
		{
			builder.HasKey(x => x.KeyId);
			builder.Property(x => x.SkillName).IsRequired().HasMaxLength(500);
			builder.Property(x => x.Score).IsRequired();

			builder.HasOne(s => s.Resume)
		   .WithMany(r => r.Skills)
		   .HasForeignKey(s => s.ResumeId);

		}
	}

	public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
	{
		public void Configure(EntityTypeBuilder<Experience> builder)
		{

			builder.HasKey(x => x.KeyId);
			builder.Property(x => x.JobTitle).IsRequired().HasMaxLength(500);
			builder.Property(x => x.Company).HasMaxLength(500);

			builder.HasOne(e => e.Resume)
			.WithMany(r => r.Experiences)
			.HasForeignKey(e => e.ResumeId);

		}
	}

	public class EducationConfiguration : IEntityTypeConfiguration<Education>
	{
		public void Configure(EntityTypeBuilder<Education> builder)
		{
			builder.HasKey(x => x.KeyId);
			builder.Property(x => x.Degree).IsRequired().HasMaxLength(355);
			builder.Property(x => x.Institution).IsRequired().HasMaxLength(500);

			builder.HasOne(e => e.Resume)
			.WithMany(r => r.Educations)
			.HasForeignKey(e => e.ResumeId);

		}
	}


}
