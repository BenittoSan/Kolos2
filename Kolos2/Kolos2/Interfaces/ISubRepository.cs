using Kolos2.Models;

namespace Kolos2.Interfaces;

public interface ISubRepository
{
    Task<Subscription?> GetSubscription(int idSub);
}