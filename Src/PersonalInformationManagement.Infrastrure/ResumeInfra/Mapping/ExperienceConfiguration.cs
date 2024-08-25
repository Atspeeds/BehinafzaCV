using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra.Mapping
{
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


}
