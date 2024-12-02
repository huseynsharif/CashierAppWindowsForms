using System;
using System.Collections.Generic;

namespace CashierApp3.Models;

public partial class Sale
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int Count { get; set; }

    public DateTime Datetime { get; set; }

    public virtual Product Product { get; set; } = null!;

    public Sale(int productId, int count, DateTime datetime)
    {
        ProductId = productId;
        Count = count;
        Datetime = datetime;
    }
}
