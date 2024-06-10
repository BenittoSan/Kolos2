using System;
using System.Collections.Generic;
using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Context;

public partial class Kolos2Context : DbContext
{
    public Kolos2Context()
    {
    }

    public Kolos2Context(DbContextOptions<Kolos2Context> options)
        : base(options)
    {
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Sale> Sales { get; set; }

}
