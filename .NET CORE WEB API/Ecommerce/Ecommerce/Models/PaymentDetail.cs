using System;
using System.Collections.Generic;

namespace Ecommerce.Models;

public partial class PaymentDetail
{
    public int ProductId { get; set; }

    public int PaymentId { get; set; }

    public string PaymentType { get; set; } = null!;

    public int TotalAmount { get; set; }

    public virtual ProductMasterTable Product { get; set; } = null!;
}
