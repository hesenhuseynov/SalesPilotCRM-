using SalesPilotCRM.Domain.Common;

namespace SalesPilotCRM.Domain.Entities
{
    public sealed class Customer : BaseEntity
    {

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? CompanyName { get; set; }

        public string? Address { get; set; }

        public int CustomerStatusId { get; set; }
        public CustomerStatus CustomerStatus { get; set; } = null!;

        public string? Notes { get; set; }

        public int? AssignedToUserId { get; set; }
        public User? AssignedToUser { get; set; }

        public DateTime? LastContactedDate { get; set; }

        public DateTime? NextFollowUpDate { get; set; }

        public int LeadScore { get; set; } = 0;

        public ICollection<Deal>? Deals { get; set; }
        public ICollection<Activity>? Activities { get; set; }

        //  elave ede bileceyim  modullar üçün navigation-lar xatirlatma sonradan 
        // public ICollection<CustomerTag> Tags { get; set; }
        // public ICollection<CustomerFile> Files { get; set; } 
    }
}
