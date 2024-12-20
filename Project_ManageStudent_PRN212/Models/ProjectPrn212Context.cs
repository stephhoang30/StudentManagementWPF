using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Project_ManageStudent_PRN212.Models;

public partial class ProjectPrn212Context : DbContext
{
    public static ProjectPrn212Context INSTANCE = new ProjectPrn212Context();
    public ProjectPrn212Context()
    {
    }

    public ProjectPrn212Context(DbContextOptions<ProjectPrn212Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentClass> StudentClasses { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlServer(config.GetConnectionString("DBContext"));
		}
	}


	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("Account");

            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.ToTable("Class");

            entity.Property(e => e.ClassName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CourseId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TeacherId).HasMaxLength(10);

            entity.HasOne(d => d.Course).WithMany(p => p.Classes)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Class_Course");

            entity.HasOne(d => d.Room).WithMany(p => p.Classes)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Class_Room");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Classes)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Class_Teacher");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.CourseId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CourseName).HasMaxLength(50);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmenId);

            entity.ToTable("Department");

            entity.Property(e => e.DepartmenId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoomName).HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Room_Department");
        });

		modelBuilder.Entity<Student>(entity =>
		{
			entity.ToTable("Student");

			entity.HasIndex(e => e.AccountId, "UQ__Student__349DA5876E55F2F1").IsUnique();

			entity.Property(e => e.Id)
				.HasMaxLength(10)
				.IsFixedLength()
				.HasColumnName("id");
			entity.Property(e => e.AccountId)
				.HasMaxLength(50)
				.HasColumnName("AccountID");
			entity.Property(e => e.Email).HasMaxLength(50);
			entity.Property(e => e.StudentName).HasMaxLength(50);

			entity.HasOne(d => d.Account).WithOne(p => p.Student)
				.HasForeignKey<Student>(d => d.AccountId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Student_Account");
		});

		modelBuilder.Entity<StudentClass>(entity =>
		{
			entity.ToTable("Student_Class");

			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.CourseId)
				.HasMaxLength(10)
				.IsFixedLength();
			entity.Property(e => e.StudentId)
				.HasMaxLength(10)
				.IsFixedLength();

			entity.HasOne(d => d.Class).WithMany(p => p.StudentClasses)
				.HasForeignKey(d => d.ClassId)
				.HasConstraintName("FK_Student_Class_Class");

			entity.HasOne(d => d.Course).WithMany(p => p.StudentClasses)
				.HasForeignKey(d => d.CourseId)
				.HasConstraintName("FK_Student_Class_Course");

			entity.HasOne(d => d.Student).WithMany(p => p.StudentClasses)
				.HasForeignKey(d => d.StudentId)
				.HasConstraintName("FK_Student_Class_Student");
		});

		modelBuilder.Entity<Teacher>(entity =>
		{
			entity.ToTable("Teacher");

			entity.HasIndex(e => e.AccountId, "UQ__Teacher__349DA58772FEE635").IsUnique();

			entity.Property(e => e.Id)
				.HasMaxLength(10)
				.HasColumnName("id");
			entity.Property(e => e.AccountId)
				.HasMaxLength(50)
				.HasColumnName("AccountID");
			entity.Property(e => e.Email).HasMaxLength(50);
			entity.Property(e => e.TeacherName).HasMaxLength(50);

			entity.HasOne(d => d.Account).WithOne(p => p.Teacher)
				.HasForeignKey<Teacher>(d => d.AccountId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Teacher_Account");
		});

		OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
