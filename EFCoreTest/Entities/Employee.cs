namespace EFCoreTest.Entities;

public class Employee: BaseEntity
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string? Title { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? HireDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? HomePhone { get; set; }

    public byte[]? Photo { get; set; }

    public string? Notes { get; set; }

    public int? ReportsTo { get; set; }
    public Employee? ReportsToNavigation { get; set; }

    public ICollection<Employee> InverseReportsToNavigation { get; set; }

    public ICollection<Order> Orders { get; set; }

}
