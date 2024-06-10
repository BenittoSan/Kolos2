using Kolos2.Context;
using Kolos2.Exceptions;
using Kolos2.Interfaces;
using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Repository;

public class SubRepository : ISubRepository
{
    private readonly Kolos2Context _dbContext;

    public SubRepository(Kolos2Context dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Subscription?> GetSubscription(int idSub)
    {
        var sub = await _dbContext.Subscriptions.Where(s => s.IdSubscription == idSub).FirstOrDefaultAsync();
        if (sub.EndTime < DateTime.Now)
        {
            throw new DomainException($"Subscriptions id off date");
        }
       
        return sub;
    }
}