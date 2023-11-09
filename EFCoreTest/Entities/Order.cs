namespace EFCoreTest.Entities;

public class Order: BaseEntity
{
    public int Id { get; set; }

    public string? OrderNo { get; set; }

    public string? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? RequiredDate { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }

    public ShipInfo ShipInfo { get; set; }
}
