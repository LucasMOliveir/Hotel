using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class Hotel : AuditableEntity
{
    public long HotelId { get; set; }

    public required string Name { get; set; }
}

