using Kolos2.Models;

namespace Kolos2.Interfaces;

public interface IClientRepository
{
    Task<Client?> GetClient(int idClient);
}