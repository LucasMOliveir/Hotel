using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class DocumentType : AuditableEntity
{
    public long DocumentTypeId { get; set; }

    public required string Name { get; set; }
}

