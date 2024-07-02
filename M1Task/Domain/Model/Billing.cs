namespace M1Task.Domain.Model;

public class Billing
{
    public int Id { get; set; }
    public DateTime OccurredAt { get; set; }
    public string TypeId { get; set; } = string.Empty;
    public string OfferId { get; set; } = string.Empty;
    public string Amount { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string Tax { get; set; } = string.Empty;
    public string OrderId { get; set; } = string.Empty;

}
