using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Databasefirst_Employee_Education.Models
{
    public partial class detailsContext : DbContext
    {
        public detailsContext()
        {
        }

        public detailsContext(DbContextOptions<detailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeEducation> EmployeeEducations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-2D3FN7GQ;Database=details;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.EmployeeAddress)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Address");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Name");
            });

            modelBuilder.Entity<EmployeeEducation>(entity =>
            {
                entity.ToTable("Employee_Education");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Course_Name");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.UniversityNmae)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("University_Nmae");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeEducations)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Employee___Emplo__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
