namespace HotelApi.Entities.BaseClasses
{
    public class AuditableEntity
    {
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public long CreatedByUser { get; set; }
    }
}
