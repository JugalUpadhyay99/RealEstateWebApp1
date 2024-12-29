using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RealEstate_DataEntity;

public partial class PractiseExampledb2Context : DbContext
{
    public PractiseExampledb2Context()
    {
    }

    public PractiseExampledb2Context(DbContextOptions<PractiseExampledb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CityMaster> CityMasters { get; set; }

    public virtual DbSet<CountryMaster> CountryMasters { get; set; }

    public virtual DbSet<LoginMaster> LoginMasters { get; set; }

    public virtual DbSet<PropertyTypeMaster> PropertyTypeMasters { get; set; }

    public virtual DbSet<PurposeMaster> PurposeMasters { get; set; }

    public virtual DbSet<RoleMaster> RoleMasters { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<UserProfileMaster> UserProfileMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TECH-CREATURE;Database=PractiseExampledb2;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CityMaster>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.ToTable("CityMaster");

            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);

            entity.HasOne(d => d.State).WithMany(p => p.CityMasters)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_CityMaster_StateMaster");
        });

        modelBuilder.Entity<CountryMaster>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("CountryMaster");

            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
        });

        modelBuilder.Entity<LoginMaster>(entity =>
        {
            entity.HasKey(e => e.LoginId);

            entity.ToTable("LoginMaster");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.LoginMasters)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_LoginMaster_RoleMaster");
        });

        modelBuilder.Entity<PropertyTypeMaster>(entity =>
        {
            entity.HasKey(e => e.PropertyTypeId);

            entity.ToTable("PropertyTypeMaster");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.PropertyTypeName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<PurposeMaster>(entity =>
        {
            entity.HasKey(e => e.PurposeId);

            entity.ToTable("PurposeMaster");

            entity.Property(e => e.PurposeId).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.PurposeName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<RoleMaster>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("RoleMaster");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("StateMaster");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.Country).WithMany(p => p.StateMasters)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_StateMaster_CountryMaster");
        });

        modelBuilder.Entity<UserProfileMaster>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserProfileMaster");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.LastName).HasMaxLength(100);

            entity.HasOne(d => d.City).WithMany(p => p.UserProfileMasters)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_UserProfileMaster_CityMaster");

            entity.HasOne(d => d.Country).WithMany(p => p.UserProfileMasters)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_UserProfileMaster_CountryMaster");

            entity.HasOne(d => d.Login).WithMany(p => p.UserProfileMasters)
                .HasForeignKey(d => d.LoginId)
                .HasConstraintName("FK_UserProfileMaster_LoginMaster");

            entity.HasOne(d => d.Role).WithMany(p => p.UserProfileMasters)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserProfileMaster_RoleMaster");

            entity.HasOne(d => d.State).WithMany(p => p.UserProfileMasters)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_UserProfileMaster_StateMaster");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
