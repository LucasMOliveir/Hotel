using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class PaymentMethod : AuditableEntity
{
    public long PaymentMethodId { get; set; }

    public required string Name { get; set; }
}

