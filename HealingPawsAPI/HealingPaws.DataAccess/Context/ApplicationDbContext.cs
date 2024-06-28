using HealingPaws.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealingPaws.DataAccess.Context;
public class ApplicationDbContext : DbContext
{
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<AppointmentEntity> Appointments { get; set; }
    public DbSet<PetBreedEntity> PetBreeds { get; set; }
    public DbSet<PetOwnerEntity> PetOwners { get; set; }
    public DbSet<PetEntity> Pets { get; set; }
    public DbSet<PetTypeEntity> PetTypes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AddressEntity>().HasQueryFilter(a => a.IsDeleted == null);
        modelBuilder.Entity<AppointmentEntity>().HasQueryFilter(a => a.IsDeleted == null);
        modelBuilder.Entity<PetBreedEntity>().HasQueryFilter(a => a.IsDeleted == null);
        modelBuilder.Entity<PetOwnerEntity>().HasQueryFilter(a => a.IsDeleted == null);
        modelBuilder.Entity<PetTypeEntity>().HasQueryFilter(a => a.IsDeleted == null);

        modelBuilder.Entity<AddressEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("AddressId");
        });

        modelBuilder.Entity<AppointmentEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("AppointmentId");
        });

        modelBuilder.Entity<PetBreedEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("PetBreedId");
        });


        modelBuilder.Entity<PetOwnerEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("PetOwnerId");
        });

        modelBuilder.Entity<PetEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("PetId");
        });

        modelBuilder.Entity<PetTypeEntity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("PetTypeId");
        });
    }
}
