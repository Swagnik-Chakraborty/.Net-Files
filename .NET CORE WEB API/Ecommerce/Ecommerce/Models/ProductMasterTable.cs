using System;
using System.Collections.Generic;

namespace Ecommerce.Models;

public partial class ProductMasterTable
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int ProductPrice { get; set; }

    public string ProductDesacription { get; set; } = null!;

    public int ProductStock { get; set; }

    public string ProductBrand { get; set; } = null!;

    public string ProductGender { get; set; } = null!;

    public string ProductCategory { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual ICollection<PaymentDetail> PaymentDetails { get; } = new List<PaymentDetail>();
}
