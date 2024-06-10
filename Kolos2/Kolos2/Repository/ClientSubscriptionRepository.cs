using Kolos2.Context;
using Kolos2.DTO.Response;
using Kolos2.Interfaces;
using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Repository;

public class ClientSubscriptionRepository: IClientSubscriptionRepository
{
    private readonly Kolos2Context _dbContext;

    public ClientSubscriptionRepository(Kolos2Context dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<ClientSubscriptionDTO>?> GetClientSubscription(int idClient)
    {
        var clientSubDto = await _dbContext.Sales
            .Where(sale => sale.IdClient == idClient)
            .Join(
                _dbContext.Subscriptions,
                sale => sale.IdSubscription,
                subscription => subscription.IdSubscription,
                (sale, subscription) => new ClientSubscriptionDTO
                {

                    IdSubscription = subscription.IdSubscription,
                    SubName = subscription.Name,
                    RenewallPeriod = subscription.RenewalPeriod,
                    TotalPaidAmount = subscription.Price * subscription.RenewalPeriod
                }
            ).ToListAsync();
        return clientSubDto;
    }
}