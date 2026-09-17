using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserDevices.Data.Entities;

namespace UserDevices.Data.Configurations;

public class UserDeviceConfiguration : IEntityTypeConfiguration<UserDevice>
{
    public void Configure(EntityTypeBuilder<UserDevice> builder)
    {
        builder.ToTable("UserDevices", "dbo");

        builder.HasKey(d => d.Id)
            .HasName("PK_UserDevices");

        builder.Property(d => d.Id)
            .HasColumnName("Id")
            .HasColumnType("bigint")
            .ValueGeneratedOnAdd();

        builder.Property(d => d.UserId)
            .HasColumnName("UserId")
            .HasColumnType("nvarchar(450)")
            .HasMaxLength(450)
            .IsRequired();

        builder.Property(d => d.DeviceToken)
            .HasColumnName("DeviceToken")
            .HasColumnType("nvarchar(500)")
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(d => d.Platform)
            .HasColumnName("Platform")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(d => d.DeviceModel)
            .HasColumnName("DeviceModel")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(d => d.AppVersion)
            .HasColumnName("AppVersion")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(d => d.LanguageCode)
            .HasColumnName("LanguageCode")
            .HasColumnType("nvarchar(10)")
            .HasMaxLength(10)
            .HasDefaultValue("en-GB")
            .IsRequired();

        builder.Property(d => d.CreatedAt)
            .HasColumnName("CreatedAt")
            .HasColumnType("datetimeoffset")
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();

        builder.Property(d => d.LastActiveAt)
            .HasColumnName("LastActiveAt")
            .HasColumnType("datetimeoffset")
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();

        builder.HasIndex(d => d.DeviceToken)
            .HasDatabaseName("UK_UserDevices_Token")
            .IsUnique();

        builder.HasIndex(d => d.UserId)
            .HasDatabaseName("IX_UserDevices_UserId");
    }
}
