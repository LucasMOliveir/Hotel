using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class ProductAndService : AuditableEntity
{
    public long ProductAndServiceId { get; set; }

    public required string Name { get; set; }

    public required string SKU { get; set; }

    public decimal Price { get; set; }
}

