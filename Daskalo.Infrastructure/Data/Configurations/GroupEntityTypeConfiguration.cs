
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daskalo.Infrastructure.Data.Configurations
{
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasMany(g => g.Members)
                .WithMany(m => m.Groups)
                .UsingEntity<GroupMember>(
                    j => j.HasOne(g => g.Member)
                        .WithMany()
                        .HasForeignKey(g => g.MemberId)
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j.HasOne(m => m.Group)
                        .WithMany()
                        .HasForeignKey(m => m.GroupId)
                        .OnDelete(DeleteBehavior.NoAction))
                .ToTable("GroupsAndMembers");

            builder
                .HasMany(g => g.Topics)
                .WithMany(t => t.Groups)
                .UsingEntity<GroupTopic>(
                    j => j.HasOne(g => g.Topic)
                        .WithMany()
                        .HasForeignKey(g => g.TopicId)
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j.HasOne(t => t.Group)
                        .WithMany()
                        .HasForeignKey(t => t.GroupId)
                        .OnDelete(DeleteBehavior.NoAction))
                .ToTable("GroupsAndTopics");

            builder
                .HasOne(g => g.Teacher)
                .WithMany()
                .HasForeignKey(g => g.TeacherId);

            builder
                .HasOne(g => g.School)
                .WithMany()
                .HasForeignKey(g => g.SchoolId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
