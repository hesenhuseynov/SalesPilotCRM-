using Microsoft.EntityFrameworkCore;
using SalesPilotCRM.Domain.Entities;

namespace SalesPilotCRM.Application.Interfaces
{
    public interface IAppWriteDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerStatus> CustomerStatuses { get; set; }
        DbSet<Deal> Deals { get; set; }
        DbSet<DealStage> DealStages { get; set; }
        DbSet<Activity> Activities { get; set; }
        DbSet<ActivityType> ActivityTypes { get; set; }
        DbSet<Notification> Notifications { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
