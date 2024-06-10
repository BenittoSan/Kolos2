using Kolos2.Context;
using Kolos2.Interfaces;
using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Repository;

public class DiscountRepository : IDiscountReposiotory
{
    private readonly Kolos2Context _dbContext;

    public DiscountRepository(Kolos2Context dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Discount?> GetDiscount(int idClient)
    {
        var Discount = await _dbContext.Discounts.Where(c => c.IdClient == idClient).FirstOrDefaultAsync();
        return Discount;

    }
}