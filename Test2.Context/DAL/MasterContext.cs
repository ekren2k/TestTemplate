using Microsoft.EntityFrameworkCore;
using Test2.Models;

namespace Test2.Context;

public class MasterContext : DbContext
{
    public MasterContext(DbContextOptions<MasterContext> options) : base(options)
    { }

    public DbSet<Record> Records { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<TaskEntity> Tasks { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskEntity>(entity => entity.ToTable("Task"));
        modelBuilder.Entity<Student>(entity => entity.ToTable("Student"));
        modelBuilder.Entity<Language>(entity => entity.ToTable("Language"));
        modelBuilder.Entity<Record>(entity => entity.ToTable("Record"));
    }
}