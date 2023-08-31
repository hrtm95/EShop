using System;
using System.Collections.Generic;

namespace EShop.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int? Quntity { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public bool? IsPaied { get; set; }

    public virtual Customer? Customer { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
