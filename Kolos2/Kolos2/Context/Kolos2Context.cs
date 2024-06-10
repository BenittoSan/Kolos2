using System;
using System.Collections.Generic;

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

}
