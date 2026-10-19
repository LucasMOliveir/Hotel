using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class HotelStayOrder : AuditableEntity
{
    public long HotelStayOrderId { get; set; }
    public long HotelId { get; set; }
    public long HotelUnitId { get; set; }
    public long PaymentMethodId { get; set; }
    public bool Paid { get; set; }
}
