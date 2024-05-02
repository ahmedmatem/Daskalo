
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Daskalo.Infrastructure.Data.Configurations.SeedHelper;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public class SchoolEntityTypeConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
                .HasMany(s => s.Members)
                .WithOne()
                .HasForeignKey(s => s.SchoolId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(Schools);
        }
    }
}
