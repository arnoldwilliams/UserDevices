using Microsoft.EntityFrameworkCore;
using UserDevices.Data.Entities;

namespace UserDevices.Data;

public class UserDevicesDbContext : DbContext
{
    public UserDevicesDbContext(DbContextOptions<UserDevicesDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserDevice> UserDevices => Set<UserDevice>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserDevicesDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
