namespace Gym_Project.Entites
{
    public class Member : GymUser
    {
        public string? Photo { get; set; } 

        public ICollection<Membership> Memberships { get; set; } = default!;
    }
}
