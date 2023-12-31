﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trader.Storage.Account.Models;

namespace Trader.Storage.Account;

public sealed class IdentityTraderDbContext : IdentityDbContext<TraderUser>
{
    public IdentityTraderDbContext(DbContextOptions<IdentityTraderDbContext> options)
        : base(options)
    {
        Database.Migrate();
    }
}