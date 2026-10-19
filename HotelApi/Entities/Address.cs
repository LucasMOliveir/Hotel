using HotelApi.Entities.BaseClasses;

namespace HotelApi.Entities;

public class Address : AuditableEntity
{
    public long AddressId { get; set; }

    public required string CountryCode { get; set; }

    public required string AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public required string City { get; set; }

    public required string State { get; set; }

    public required string Neighborhood { get; set; }

    public long AddressTypeId { get; set; }
}

