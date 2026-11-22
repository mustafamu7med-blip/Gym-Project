using Gym_Project.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Project.Context.Configurations
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50);

            builder.Property(X => X.Email)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100);

            builder.Property(X => X.Phone)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(11);

            builder.ComplexProperty(X => X.Address);

            builder.HasIndex(X => X.Email)
                   .IsUnique();

            builder.HasIndex(X => X.Phone)
                   .IsUnique();

            builder.ToTable(T =>
            {

                T.HasCheckConstraint("CK_Email", "Email LIKE '_%@%.com'");
                T.HasCheckConstraint("CK_Phone", "LEN(Phone) = 11 AND (Phone LIKE '012%' OR Phone LIKE '015%' OR Phone LIKE '010%' OR Phone LIKE '011%')");

            }
            );
        }
    }
}
