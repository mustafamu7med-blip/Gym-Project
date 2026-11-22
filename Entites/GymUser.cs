using Gym_Project.Entites.Enums;

namespace Gym_Project.Entites
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public DateOnly DOB { get; set; } 
        public Gender Gender { get; set; } 
    }
}
