namespace EFCoreTest.Entities;

public class Customer: BaseEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string CompanyName { get; set; } = string.Empty;

    public string? Title { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public ICollection<Order> Orders { get; set; }
}
