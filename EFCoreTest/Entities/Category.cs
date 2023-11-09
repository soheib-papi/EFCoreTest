using System;
using System.Collections.Generic;

namespace EFCoreTest.Entities;

public class Category: BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public ICollection<Product> Products { get; set; }
}
