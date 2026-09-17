namespace UserDevices.Data.Entities;

/// <summary>
/// A mobile push-notification token registered by a distinct internal identity.
/// </summary>
public class UserDevice
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string DeviceToken { get; set; } = null!;

    public string Platform { get; set; } = null!;

    public string? DeviceModel { get; set; }

    public string? AppVersion { get; set; }

    public string LanguageCode { get; set; } = null!;

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset LastActiveAt { get; set; }
}
