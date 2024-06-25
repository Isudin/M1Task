
public class BillingEntries
{
    public BillingEntry[] BillingEntries { get; set; }
}

public class BillingEntry
{
    public string Id { get; set; }
    public DateTime OccurredAt { get; set; }
    public Type Type { get; set; }
    public Offer Offer { get; set; }
    public Value Value { get; set; }
    public Tax Tax { get; set; }
    public Balance Balance { get; set; }
    public Order Order { get; set; }
}

public class Type
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Offer
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Value
{
    public string Amount { get; set; }
    public string Currency { get; set; }
}

public class Tax
{
    public string Percentage { get; set; }
    public string Annotation { get; set; }
}

public class Balance
{
    public string Amount { get; set; }
    public string Currency { get; set; }
}

public class Order
{
    public string Id { get; set; }
}
