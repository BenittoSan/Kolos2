using Kolos2.DTO.Response;

namespace Kolos2.Interfaces;

public interface IClientSubscriptionService
{
    Task<InfoClientSubDTO?> GetInfoClientSub(int idClient);
}