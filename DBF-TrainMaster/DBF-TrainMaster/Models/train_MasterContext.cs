using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBF_TrainMaster.Models
{
    public partial class train_MasterContext : DbContext
    {
        public train_MasterContext()
        {
        }

        public train_MasterContext(DbContextOptions<train_MasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RunningDay> RunningDays { get; set; } = null!;
        public virtual DbSet<TrainMaster> TrainMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-2D3FN7GQ;Database=train_Master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RunningDay>(entity =>
            {
                entity.HasKey(e => e.SNo)
                    .HasName("PK__RunningD__A3DD670ABB27D225");

                entity.Property(e => e.SNo)
                    .ValueGeneratedNever()
                    .HasColumnName("S_No");

                entity.Property(e => e.RunningDays)
                    .IsUnicode(false)
                    .HasColumnName("Running_Days");

                entity.HasOne(d => d.TrainNoNavigation)
                    .WithMany(p => p.RunningDays)
                    .HasForeignKey(d => d.TrainNo)
                    .HasConstraintName("FK__RunningDa__Train__30F848ED");
            });

            modelBuilder.Entity<TrainMaster>(entity =>
            {
                entity.HasKey(e => e.TrainNo)
                    .HasName("PK__TrainMas__8ED1D8CD6F4CEFD7");

                entity.ToTable("TrainMaster");

                entity.Property(e => e.TrainNo).ValueGeneratedNever();

                entity.Property(e => e.FromStation)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("From_station");

                entity.Property(e => e.JourneyEndTime).HasColumnName("Journey_EndTime");

                entity.Property(e => e.JourneyStartTime).HasColumnName("Journey_StartTime");

                entity.Property(e => e.ToStation)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("To_station");

                entity.Property(e => e.TrainName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Train_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
