namespace EFCoreTest.Entities;

public class Supplier: BaseEntity
{
    public int Id { get; set; }
    
    public string? Name { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactTitle { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? HomePage { get; set; }

    public ICollection<SupplierProduct> SupplierProducts { get; set; }
}
