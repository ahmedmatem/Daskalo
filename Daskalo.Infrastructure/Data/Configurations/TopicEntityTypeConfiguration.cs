
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public class TopicEntityTypeConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasMany(t => t.Resources)
                .WithMany(r => r.Topics)
                .UsingEntity<TopicAndResource>(
                    j => j.HasOne(x => x.TopicResource)
                        .WithMany()
                        .HasForeignKey(t => t.TopicResurceId)
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j.HasOne(x => x.Topic)
                        .WithMany()
                        .HasForeignKey(r => r.TopicId)
                        .OnDelete(DeleteBehavior.NoAction)
                )
                .ToTable("TopicsAndResources");
        }
    }
}
