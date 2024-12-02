using System;
using System.Collections.Generic;

namespace CashierApp3.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public int Count { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
