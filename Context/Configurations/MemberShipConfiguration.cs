using Gym_Project.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Project.Context.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(X => X.Id);

            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");


        }
    }
}
