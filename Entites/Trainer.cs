using Gym_Project.Entites.Enums;

namespace Gym_Project.Entites
{
    public class Trainer : GymUser
    {
        public Specialties Specialty { get; set; }

        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
