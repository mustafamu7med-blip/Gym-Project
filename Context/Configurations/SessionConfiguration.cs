using Gym_Project.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Project.Context.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("SessionCapacityCheck", "Capacity Between 1 And 25");

                X.HasCheckConstraint("SessionEndDateCheck", "EndDate > StartDate");

            }

            );
        }
    }
}
