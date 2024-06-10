using Kolos2.DTO.Response;
using Kolos2.Exceptions;
using Kolos2.Interfaces;

namespace Kolos2.Services;

public class ClientSubscriptionService : IClientSubscriptionService
{
    private readonly IClientRepository _clientRepository;
    private readonly  IDiscountReposiotory _discountReposiotory;
    private readonly  IClientSubscriptionRepository _clientSubscriptionRepository;

    public ClientSubscriptionService(IClientRepository clientRepository, IDiscountReposiotory discountReposiotory,
        IClientSubscriptionRepository clientSubscriptionRepository)
    {
        _clientRepository = clientRepository;
        _discountReposiotory = discountReposiotory;
        _clientSubscriptionRepository = clientSubscriptionRepository;
    }
    
    public async Task<InfoClientSubDTO?> GetInfoClientSub(int idClient)
    {
        var client = await _clientRepository.GetClient(idClient);
        if (client == null)
        {
            throw new DomainException($"Client with id {idClient} does not exist");
        }

        var clientSub = await _clientSubscriptionRepository.GetClientSubscription(idClient);

        var discount = await _discountReposiotory.GetDiscount(idClient);

        InfoClientSubDTO response = new InfoClientSubDTO
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
            Phone = client.Phone,
            Discount = discount.Value,
            ClientSubscriptionDto = clientSub
        };
        return response;
    }
}