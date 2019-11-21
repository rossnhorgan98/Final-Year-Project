/* This class was scaffolded using the following packet manager console command:
   Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models */

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FYP.Models
{
    public partial class InventoryContext : DbContext
    {
        public InventoryContext()
        {
        }

        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP2;Database=Inventory;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ClimateDescription).IsUnicode(false);

                entity.Property(e => e.ClimateType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostOfLivingIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Forum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralDescription).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PollutionIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchasingPowerIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QualityOfLifeIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RentIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SafetyIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrafficRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransportDescription).IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_City");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AverageWage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CorporationTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EducationDescription).IsUnicode(false);

                entity.Property(e => e.Gdp).HasColumnName("GDP");

                entity.Property(e => e.Hdi)
                    .HasColumnName("HDI")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HomicideRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LanguageS)
                    .HasColumnName("Language(s)")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaxIncomeTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinIncomeTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinnimumWage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PensionIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxDescription).IsUnicode(false);

                entity.Property(e => e.UnemploymentRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
