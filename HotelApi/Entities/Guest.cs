using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class Guest : AuditableEntity
{
    public long GuestId { get; set; }

    public required string Name { get; set; }

    public long DocumentTypeId { get; set; }

    public long DocumentId { get; set; }
}

