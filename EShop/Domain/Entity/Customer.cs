using System;
using System.Collections.Generic;

namespace EShop.Domain.Entity;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public bool? IsActive { get; set; }

    public string? Address { get; set; }

    public virtual Cart IdNavigation { get; set; } = null!;
}
