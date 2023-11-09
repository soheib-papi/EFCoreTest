namespace EFCoreTest.Entities;

public class BaseEntity
{
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public byte[] RowVersion { get; set; }
}
