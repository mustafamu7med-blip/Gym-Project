namespace Gym_Project.Entites
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string Description { get; set; } = default!;
        public int DurationDays { get; set; }
        public bool IsActive { get; set; } 
        public ICollection<Membership> Memberships { get; set; } = default!;
    }
}
