/* This class was scaffolded using the following packet manager console command:
   Scaffold-DbContext “Server=DESKTOP2;Database=Inventory;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models */

using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FYP.Models
{
    public partial class InventoryContext : IdentityDbContext<ApplicationUser>
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
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }

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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ClimateDescription).IsUnicode(false);

                entity.Property(e => e.ClimateImage).IsUnicode(false);

                entity.Property(e => e.ClimateType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostOfLivingIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.GeneralPicture).IsUnicode(false);

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

                entity.Property(e => e.TransportImage).IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("float");

                entity.Property(e => e.Longitude).HasColumnType("float");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_City");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID");

                entity.Property(e => e.AverageWage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Continent).HasMaxLength(50).IsUnicode(false).IsRequired();

                entity.Property(e => e.CorporationTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Gdp).HasColumnName("GDP");

                entity.Property(e => e.Flag).IsUnicode(false);

                entity.Property(e => e.Hdi)
                    .HasColumnName("HDI")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HomicideRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LanguageS)
                    .HasColumnName("Language(s)")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Map).IsUnicode(false);

                entity.Property(e => e.MaxIncomeTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinIncomeTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinnimumWage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PensionIndex).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnemploymentRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(18, 2)");
            });          

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
