using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class Document : AuditableEntity
{
    public long DocumentId { get; set; }
    public long DocumentTypeId { get; set; }
    public required string DocumentNumber { get; set; }
}

