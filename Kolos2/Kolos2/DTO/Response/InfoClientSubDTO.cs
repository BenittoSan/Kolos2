namespace Kolos2.DTO.Response;

public class InfoClientSubDTO
{
     
     public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public int Discount { get; set; }
    public ICollection<ClientSubscriptionDTO?> ClientSubscriptionDto { get; set; }
}