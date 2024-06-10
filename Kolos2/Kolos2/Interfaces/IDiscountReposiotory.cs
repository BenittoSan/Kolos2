using Kolos2.Models;

namespace Kolos2.Interfaces;

public interface IDiscountReposiotory
{
    Task<Discount?> GetDiscount(int idClient);
}