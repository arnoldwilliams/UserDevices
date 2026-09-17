using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UserDevices.Data;

public class UserDevicesDbContextFactory : IDesignTimeDbContextFactory<UserDevicesDbContext>
{
    public UserDevicesDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<UserDevicesDbContext>()
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UserDevices;Trusted_Connection=True;")
            .Options;

        return new UserDevicesDbContext(options);
    }
}
