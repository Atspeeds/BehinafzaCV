using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra.Mapping
{
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


}
