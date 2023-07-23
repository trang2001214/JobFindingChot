using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace JobFindingChot.Models
{
    public partial class JobFindingChot1Context : DbContext
    {
        public JobFindingChot1Context()
        {
        }

        public JobFindingChot1Context(DbContextOptions<JobFindingChot1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountStatus> AccountStatuses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<JobApply> JobApplies { get; set; }
        public virtual DbSet<JobApplyStatus> JobApplyStatuses { get; set; }
        public virtual DbSet<PostJob> PostJobs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public object Configuration { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=JobFindingChot1; Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_AccountStatus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Roles_Accounts");
            });

            modelBuilder.Entity<AccountStatus>(entity =>
            {
                entity.ToTable("AccountStatus");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountStatus1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("AccountStatus");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Logo).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Accounts");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AttachCv)
                    .IsRequired()
                    .HasColumnName("AttachCV");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Cnic)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Fnic)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FNIC");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Photo).IsRequired();

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Accounts");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Categories");
            });

            modelBuilder.Entity<JobApply>(entity =>
            {
                entity.ToTable("JobApply");

                entity.Property(e => e.JobApplyId).HasColumnName("JobApplyID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.JobApplyDateTime).HasColumnType("datetime");

                entity.Property(e => e.JobApplyStatusId).HasColumnName("JobApplyStatusID");

                entity.Property(e => e.JobApplyStatusUpDateReason)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.JobApplyStatusUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PostJobId).HasColumnName("PostJobID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.JobApplies)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobApply_Employees");

                entity.HasOne(d => d.JobApplyStatus)
                    .WithMany(p => p.JobApplies)
                    .HasForeignKey(d => d.JobApplyStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobApply_JobApplyStatus");

                entity.HasOne(d => d.PostJob)
                    .WithMany(p => p.JobApplies)
                    .HasForeignKey(d => d.PostJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobApply_PostJob");
            });

            modelBuilder.Entity<JobApplyStatus>(entity =>
            {
                entity.ToTable("JobApplyStatus");

                entity.Property(e => e.JobApplyStatusId).HasColumnName("JobApplyStatusID");

                entity.Property(e => e.JobApplyStatus1)
                    .HasMaxLength(150)
                    .HasColumnName("JobApplyStatus");
            });

            modelBuilder.Entity<PostJob>(entity =>
            {
                entity.ToTable("PostJob");

                entity.Property(e => e.PostJobId).HasColumnName("PostJobID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ApplicationLastDate).HasColumnType("datetime");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.PostJobs)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostJob_Accounts");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.PostJobs)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostJob_Categories");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PostJobs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostJob_Company");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
