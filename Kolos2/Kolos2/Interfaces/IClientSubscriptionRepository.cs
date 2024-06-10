using Kolos2.DTO.Response;

namespace Kolos2.Interfaces;

public interface IClientSubscriptionRepository
{
    Task<ICollection<ClientSubscriptionDTO?>> GetClientSubscription(int idClient);
}