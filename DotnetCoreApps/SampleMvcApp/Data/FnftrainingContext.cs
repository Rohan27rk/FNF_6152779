using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleMvcApp.Data;

public partial class FnftrainingContext : DbContext
{
    public FnftrainingContext()
    {
    }

    public FnftrainingContext(DbContextOptions<FnftrainingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=FNFIDVPRE22648;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC073C79871B");

            entity.ToTable("Employee");

            entity.Property(e => e.EmpAddress).HasMaxLength(200);
            entity.Property(e => e.EmpName).HasMaxLength(50);
            entity.Property(e => e.EmpSalary).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
