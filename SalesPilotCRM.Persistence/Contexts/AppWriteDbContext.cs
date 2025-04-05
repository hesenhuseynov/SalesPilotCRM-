using Microsoft.EntityFrameworkCore;
using SalesPilotCRM.Application.Interfaces;
using SalesPilotCRM.Domain.Entities;

namespace SalesPilotCRM.Persistence.Contexts
{
    public class AppWriteDbContext : DbContext, IAppWriteDbContext
    {
        public AppWriteDbContext(DbContextOptions<AppWriteDbContext> options)
        : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerStatus> CustomerStatuses { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<DealStage> DealStages { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppWriteDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
               => base.SaveChangesAsync(cancellationToken);

    }
}
