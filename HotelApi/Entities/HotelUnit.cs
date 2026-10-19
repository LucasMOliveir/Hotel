using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class HotelUnit : AuditableEntity
{
    public long HotelUnitId { get; set; }

    public long HotelId { get; set; }

    public long AddressId { get; set; }
}

