using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Areas.Identity.Data;

namespace StudentManagementSystem.Areas.Identity.Data;

public class StudentDBContext : IdentityDbContext<StudentUser>
{
    public StudentDBContext(DbContextOptions<StudentDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityCofiguration());
    }
}

public class ApplicationUserEntityCofiguration : IEntityTypeConfiguration<StudentUser>
{
    public void Configure(EntityTypeBuilder<StudentUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);
    }
}