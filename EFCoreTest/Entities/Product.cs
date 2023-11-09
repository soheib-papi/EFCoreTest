namespace EFCoreTest.Entities;

public class Product: BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    public decimal? UnitPrice { get; set; }

    public bool IsActive { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }

    public ICollection<SupplierProduct> SupplierProducts { get; set; }
}
