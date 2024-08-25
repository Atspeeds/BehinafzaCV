using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInformationManagement.Domain.ResumeAgg;

namespace PersonalInformationManagement.Infrastrure.ResumeInfra.Mapping
{
    public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {

            builder.HasKey(x => x.KeyId);
            builder.Property(x => x.Summary).IsRequired();

        }
    }


}
