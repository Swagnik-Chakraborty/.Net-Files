using System;
using System.Collections.Generic;

namespace Ecommerce.Models;

public partial class OrderDetail
{
    public int ProductId { get; set; }

    public int OrderId { get; set; }

    public int Price { get; set; }

    public int Discount { get; set; }

    public int TotalAmount { get; set; }

    public virtual ProductMasterTable Product { get; set; } = null!;
}
