﻿namespace M1Task.Domain.Model.Database;

public partial class OrderTable
{
    public int Id { get; set; }

    public string OrderId { get; set; } = null!;

    public int? ErpOrderId { get; set; }

    public int? InvoiceId { get; set; }

    public int? StoreId { get; set; }
}
