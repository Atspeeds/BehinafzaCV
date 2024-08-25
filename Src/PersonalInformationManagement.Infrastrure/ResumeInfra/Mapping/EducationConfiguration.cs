using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra.Mapping
{
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
