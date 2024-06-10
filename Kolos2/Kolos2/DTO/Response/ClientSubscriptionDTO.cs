namespace Kolos2.DTO.Response;

public class ClientSubscriptionDTO
{
    public int IdClient { get; set; }
    public int IdSubscription { get; set; }
    public string SubName { get; set; }
    public int RenewallPeriod { get; set; }
    public double TotalPaidAmount { get; set; }
}