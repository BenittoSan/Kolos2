using Kolos2.Context;
using Kolos2.Interfaces;
using Kolos2.Models;
using Microsoft.EntityFrameworkCore;


namespace Kolos2.Repository;

public class ClientRepository : IClientRepository
{
    private readonly Kolos2Context _dbContext;

    public ClientRepository(Kolos2Context dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Client?> GetClient(int idClient)
    {
        var client = await _dbContext.Clients.Where(c => c.IdClient == idClient).FirstOrDefaultAsync();
        return client;
    }
}