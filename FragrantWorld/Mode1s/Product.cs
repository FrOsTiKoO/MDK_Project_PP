using System;
using System.Collections.Generic;

namespace FragrantWorld.Mode1s;

public partial class Product
{
    public string ProductArticleNumber { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public int ProductCategoryId { get; set; }

    public byte[]? ProductPhoto { get; set; }

    public int ProductManufacturerId { get; set; }

    public decimal ProductCost { get; set; }

    public byte? ProductDiscountAmount { get; set; }

    public int ProductQuantityInStock { get; set; }

    public string ProductStatus { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
