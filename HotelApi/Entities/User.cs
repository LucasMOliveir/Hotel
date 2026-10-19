using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class User : AuditableEntity
{
    public long UserId { get; set; }
    public required string Name { get; set; }
}

