using Daskalo.Infrastructure.Data.Configurations;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Infrastructure.Data.Models.QuizModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SchoolEntityTypeConfiguration());
            builder.ApplyConfiguration(new GroupEntityTypeConfiguration());
            builder.ApplyConfiguration(new TopicEntityTypeConfiguration());

            builder.ApplyConfiguration(new IdentityRoleEntityTypeConfiguration());
            builder.ApplyConfiguration(new IdentityEntityTypeConfiguration());
            builder.ApplyConfiguration(new IdentityUserRoleEntityTypeConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Group> Groups { get; set; } = null!;

        public DbSet<ApplicationUser> Schools { get; set; } = null!;

        public DbSet<Topic> Topics { get; set; } = null!;

        public DbSet<TopicResource> TopicResources { get; set; } = null!;

        public DbSet<Quiz> Quizzes { get; set; } = null!;

        public DbSet<Question> Questions { get; set; } = null!;

        public DbSet<Option> Options { get; set; } = null!;

        public override Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
