using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class HotelStayOrderItem : AuditableEntity
{
    public long HotelStayOrderItemId { get; set; }

    public long ProductAndServiceId { get; set; }

    public int Quantity { get; set; }

    public decimal Discount { get; set; }

    public DateTimeOffset? StayCheckIn { get; set; }

    public DateTimeOffset? StayCheckOut { get; set; }
}

