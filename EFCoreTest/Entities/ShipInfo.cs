namespace EFCoreTest.Entities;

public class ShipInfo
{
    public int Id { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal? Freight { get; set; }

    public string? ShipName { get; set; }

    public string? ShipAddress { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }
}
