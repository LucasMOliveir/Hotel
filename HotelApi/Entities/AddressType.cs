using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class AddressType : AuditableEntity
{
    public long AddressTypeId { get; set; }

    public required string Name { get; set; }
}

